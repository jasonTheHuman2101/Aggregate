using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
    public class Sources
    {
        public List<Source> sources { get; set; }
    }
    public class Source
    {
        public string sourceName { get; set; }
        public string sourceDir { get; set; }
        public string imageUrl { get; set; }
    }
}
