using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesHirek.Models;

namespace RazorPagesHirek.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesHirek.Models.RazorPagesHirekContext _context;

        public IndexModel(RazorPagesHirek.Models.RazorPagesHirekContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Article.ToListAsync();
        }
    }
}
