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
            FeedContent tfc = new FeedContent("LLamas", "A tag", "Jason", "https://www.youtube.com/watch?app=desktop&v=dQw4w9WgXcQ%2F", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.-CaKxUEfsklR87DAaAUYCwHaFj%26pid%3DApi&f=1");
            tfc.Location = new Point(2, 15);
            storyPanel.Controls.Add(tfc);
        }
    }
}
