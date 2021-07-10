using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace Aggregate
{
    public partial class EditSources : Form
    {
        Sources scs;
        int selectedSourceIndex;

        public EditSources()
        {
            InitializeComponent();
            loadSources();
        }

        void loadSources() //Loads in the sources and puts them in as buttons. Below is the action for ButtonClicked events
        {
            sourcesPanel.Controls.Clear();
            openFile();

            int x = 0;

            foreach(Source source in scs.sources)
            {
                int newLocation = x * 35;

                Button bttn = new Button();
                bttn.Text = source.sourceName;
                bttn.Location = new Point(0, newLocation);
                bttn.Width = 275;
                bttn.Height = 30;
                bttn.Click += SourceButtonClicked;
                bttn.Name = ""+x;
                sourcesPanel.Controls.Add(bttn);
                x++;
            }
        }

        private void SourceButtonClicked(object sender, EventArgs e)
        {
            selectedSourceIndex= Int32.Parse(((Button)sender).Name); //Name value is the index of the source in the list
            Source activeSource = scs.sources[selectedSourceIndex];
            sourceName.Text = activeSource.sourceName;
            sourceUrl.Text = activeSource.sourceDir;
            sourceImage.Text = activeSource.imageUrl;
            sourceImagePreview.LoadAsync(activeSource.imageUrl);
        }

        void openFile()
        {
            try
            {
                string json = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.aggregate/sources.json");
                scs = JsonConvert.DeserializeObject<Sources>(json);
            }
            catch (Exception e)
            {
                string tempJson = "{\"sources\":[{\"sourceName\":\"BBC News\",\"sourceDir\":\"http://feeds.bbci.co.uk/news/rss.xml?edition=uk#\",\"imageUrl\":\"https://news.bbcimg.co.uk/nol/shared/img/bbc_news_120x60.gif\"}]}";
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.aggregate"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.aggregate");
                }
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.aggregate/sources.json", tempJson);
                MessageBox.Show("An error occured when attempting to load news sources from their file. A new Aggregate folder and source folder has been created.\nIf this is a new installation, don't worry! This is expected to happen.", "Error loading sources from file.");
                scs = JsonConvert.DeserializeObject<Sources>(tempJson);
                Console.WriteLine(tempJson);
            }
        }

        void saveFile()
        {
            string json = JsonConvert.SerializeObject(scs);
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.aggregate/sources.json", json);

            openFile();
        }

        private void addSrcBttn_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();//  ----¬
                xmlDoc.Load(newSourceURL.Text);// ---- ---- ---- ---- ---- \-- Loads the RSS feed into the program. The value in .Load defines the URL

                //XmlNodeList nodes = xmlDoc.SelectNodes("rss/channel/item"); //Selects all the items in the RSS feed.
                XmlNode chan = xmlDoc.SelectSingleNode("rss/channel");

                XmlNode title = chan.SelectSingleNode("title");
                XmlNode img = chan.SelectSingleNode("image");
                XmlNode imglink = img.SelectSingleNode("url");

                string ti = title.InnerText;
                string im = imglink.InnerText;

                Source source = new Source();
                source.imageUrl = im;
                source.sourceDir = newSourceURL.Text;
                source.sourceName = ti;
                scs.sources.Add(source);
                selectedSourceIndex = scs.sources.Count - 1;

                sourceName.Text = ti;
                sourceUrl.Text = newSourceURL.Text;
                sourceImage.Text = im;
                sourceImagePreview.LoadAsync(im);

                //XmlNode rssSubNodeDesc = node.SelectSingleNode("description");
                //article.description = rssSubNodeDesc.InnerText;

                //XmlNode rssSubNodeImg = node.SelectSingleNode("enclosure");
                //if (rssSubNodeImg != null && rssSubNodeImg.Attributes["type"].Value.StartsWith("image"))
                //{
                //    article.image = rssSubNodeImg.Attributes["url"].Value;
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured. \n" + ex.Message, "Error");
            }
        }

        private void updateSource_Click(object sender, EventArgs e)
        {
            Source newSource = new Source();
            newSource.imageUrl = sourceImage.Text;
            newSource.sourceDir = sourceUrl.Text;
            newSource.sourceName = sourceName.Text;
            scs.sources[selectedSourceIndex] = newSource;

            saveFile();
            loadSources();
        }

        private void deleteSource_Click(object sender, EventArgs e)
        {
            scs.sources.RemoveAt(selectedSourceIndex);
            sourceName.Text = String.Empty;
            sourceUrl.Text = String.Empty;
            sourceImage.Text = String.Empty;
            saveFile();
            loadSources();
        }
    }
}
