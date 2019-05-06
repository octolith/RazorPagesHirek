using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesHirek.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ArticleText { get; set; }

        public IList<Comment> Comments { get; set; }
    }
}
