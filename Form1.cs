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
    public partial class MainForm : Form
    {
        static Sources scs;
        static Articles arts;

        public MainForm()
        {
            InitializeComponent();
            loadData();
            #region DISPLAY DATA IN EMERGENCY
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
            #endregion
        }

        void loadData()
        {
            progBar.Show();
            feedPanel.Controls.Clear();
            storyPanel.Controls.Clear();

            GetSourcesFromFile();
            DisplaySources();
            DisplayArticles();
            progBar.Hide();
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

        void DisplayArticles()
        {
            int i = 0;
            LoadArticles();
            foreach(Article a in arts.articles)
            {
                int y = 15 + i * 95;
                FeedContent fc = new FeedContent(a.title, a.tags, a.author, a.link, a.image);
                fc.Location = new Point(2, y);
                storyPanel.Controls.Add(fc);
                i++;
            }
        }

        void LoadArticles()
        {
            arts = new Articles();
            arts.articles = new List<Article>();
            
            foreach(Source s in scs.sources)
            {
                string xmlUrl = s.sourceDir;
                string pub = s.sourceName;

                //As the articles are in XML format (as per RSS Standars) putting them into a format i can (and am  willing to) work with may get messy, so i separated it from displaying methods
                XmlDocument xmlDoc = new XmlDocument();//  ----¬
                xmlDoc.Load(xmlUrl);// ---- ---- ---- ---- ---- \-- Loads the RSS feed into the program. The value in .Load defines the URL

                XmlNodeList nodes = xmlDoc.SelectNodes("rss/channel/item"); //Selects all the items in the RSS feed.

                foreach (XmlNode node in nodes)
                {
                    Article article = new Article();
                    XmlNode rssSubNodeTitle = node.SelectSingleNode("title");
                    if (rssSubNodeTitle.InnerText.StartsWith("<")) { }
                    else
                    {
                        article.title = rssSubNodeTitle.InnerText;

                        XmlNode rssSubNodeLink = node.SelectSingleNode("link");
                        article.link = rssSubNodeLink.InnerText;

                        XmlNode rssSubNodeDesc = node.SelectSingleNode("description");
                        if (rssSubNodeDesc != null)
                        {
                            article.description = rssSubNodeDesc.InnerText;
                        }
                        else
                        {
                            article.description = "No Description";
                        }

                        XmlNode rssSubNodeImg = node.SelectSingleNode("enclosure");
                        if (rssSubNodeImg != null && rssSubNodeImg.Attributes["type"].Value.StartsWith("image"))
                        {
                            article.image = rssSubNodeImg.Attributes["url"].Value;
                        }
                        else
                        {
                            article.image = "https://www.colorhexa.com/707070.png";
                        }

                        //XmlNode rssSubNodeCat = node.SelectSingleNode("category");
                        //article.tags = rssSubNodeCat.InnerText;
                        article.tags = "";
                        //Somehow, you need to incorporate a way to get the source and categories, jason! ----------------------------------------------------------------493585283475243809752764560413875097
                        article.author = pub;

                        arts.articles.Add(article); //Adds the article to the list of articles
                    }
                }
            }
        }

        private void editSources_Click(object sender, EventArgs e)
        {
            EditSources es = new EditSources();
            es.ShowDialog();
            loadData();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
