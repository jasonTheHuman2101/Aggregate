using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aggregate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

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
        static void GetSourcesFromFile()
        {

        }
    }
}
