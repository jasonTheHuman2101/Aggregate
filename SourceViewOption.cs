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
    public partial class SourceViewOption : UserControl
    {
        public SourceViewOption(string name, string logoLocation)
        {
            InitializeComponent();
            providerName.Text = name;
            providerLogo.LoadAsync(logoLocation);
        }
    }
}
