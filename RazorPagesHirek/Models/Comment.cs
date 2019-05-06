using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesHirek.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string CommentText { get; set; }
        public Article Article { get; set; }
    }
}
