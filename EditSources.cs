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
using Newtonsoft.Json;

namespace Aggregate
{
    public partial class EditSources : Form
    {
        Sources scs;

        public EditSources()
        {
            InitializeComponent();
            loadSources();
        }

        void loadSources()
        {
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
            string clicked = ((Button)sender).Name;
            Console.WriteLine(clicked);
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
    }
}
