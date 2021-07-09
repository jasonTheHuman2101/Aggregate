using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Aggregate
{
    public partial class MainForm : Form
    {
        static Sources scs;

        public MainForm()
        {
            InitializeComponent();
            GetSourcesFromFile();
            DisplaySources();
            //Displays articles
            //FeedContent[] fc = new FeedContent[10];
            //int x = 0;
            //while (x < 10)
            //{
            //    fc[x] = new FeedContent("LLamas", "A tag", "Jason", "https://www.youtube.com/watch?app=desktop&v=dQw4w9WgXcQ%2F", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.-CaKxUEfsklR87DAaAUYCwHaFj%26pid%3DApi&f=1");
            //    fc[x].Location = new Point(2, 15 + (x * 95));
            //    storyPanel.Controls.Add(fc[x]);
            //    x++;
            //}

            //Adds a news source
            //SourceViewOption svo = new SourceViewOption("Jason News", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fimg12.deviantart.net%2F2f45%2Fi%2F2009%2F028%2F1%2F0%2Ffunny_dog_2_by_cathita.jpg&f=1&nofb=1");
            //feedPanel.Controls.Add(svo);
        }
        void GetSourcesFromFile()
        {
            #region IF DATA NEEDS GENERATING, VIEW THE FOLLOWING
            //Sources srcs = new Sources();
            //srcs.sources = new List<Source>();
            //Source s = new Source();
            //s.imageUrl = "https://news.bbcimg.co.uk/nol/shared/img/bbc_news_120x60.gif";
            //s.sourceDir = "http://feeds.bbci.co.uk/news/rss.xml?edition=uk#";
            //s.sourceName = "BBC News";
            //srcs.sources.Add(s);
            //srcs.sources.Add(s);

            //string json = JsonConvert.SerializeObject(srcs);
            //Console.WriteLine(json);
            #endregion
            //Load The File
            try
            {
                string json = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.aggregate/sources.json");
                scs = JsonConvert.DeserializeObject<Sources>(json);
            }
            catch(Exception e)
            {
                string tempJson = "{\"sources\":[{\"sourceName\":\"BBC News\",\"sourceDir\":\"http://feeds.bbci.co.uk/news/rss.xml?edition=uk#\",\"imageUrl\":\"https://news.bbcimg.co.uk/nol/shared/img/bbc_news_120x60.gif\"}]}";
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.aggregate"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.aggregate");
                }
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.aggregate/sources.json", tempJson);
                MessageBox.Show("An error occured when attempting to load news sources from their file. A new Aggregate folder and source folder has been created.\nIf this is a new installation, don't worry! This is expected to happen.","Error loading sources from file.");
                scs = JsonConvert.DeserializeObject<Sources>(tempJson);
                Console.WriteLine(tempJson);
            }
        }

        void DisplaySources()
        {
            int x = 0;
            foreach(Source s in scs.sources)
            {
                SourceViewOption svo = new SourceViewOption(s.sourceName, s.imageUrl);
                int yLoc = 15 + (x * 60);
                svo.Location = new Point(9, yLoc);
                feedPanel.Controls.Add(svo);
                Console.WriteLine("Added");
                x++;
            }
        }
    }
}
