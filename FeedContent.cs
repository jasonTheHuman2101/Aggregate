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
    public partial class FeedContent : UserControl
    {
        string webAddress;

        public FeedContent(string title, string tags, string publisher, string webAddr, string imageLoc)
        {
            InitializeComponent();
            DisplayData(title, tags, publisher, webAddr, imageLoc);
        }
        private void DisplayData(string title, string tags, string publisher, string webAddr, string imageLoc)
        {
            storyTitleLabel.Text = title;
            storySourceAndTags.Text = "Published By: " + publisher + ", Tags: " + tags;
            webAddress = webAddr;
            storyImage.LoadAsync(imageLoc);
            this.Click += FeedContent_Click;
        }

        private void FeedContent_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Click Detected");
            Browser b = new Browser(webAddress);
            b.Show();
        }
    }
}
