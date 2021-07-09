using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
    class Articles
    {
        public List<Article> articles { get; set; }
    }
    class Article
    {
        public string title { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string pubdate { get; set; }
        public string tags { get; set; }
        public string image { get; set; }
    }
}
