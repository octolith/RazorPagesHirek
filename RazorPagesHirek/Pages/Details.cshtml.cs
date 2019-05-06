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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesHirek.Models.RazorPagesHirekContext _context;

        public DetailsModel(RazorPagesHirek.Models.RazorPagesHirekContext context)
        {
            _context = context;
        }

        public Article Article { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article = await _context.Article.FirstOrDefaultAsync(m => m.ID == id);

            if (Article == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
