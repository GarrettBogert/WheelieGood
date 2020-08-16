using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WheelieGood.Core;
using WheelieGood.Data;

namespace WheelieGood.Pages.Articles
{
    public class DetailsModel : PageModel
    {
        private readonly WheelieGood.Data.WheelieGoodDbContext _context;

        public DetailsModel(WheelieGood.Data.WheelieGoodDbContext context)
        {
            _context = context;
        }

        public Article Article { get; set; }

        public async Task<IActionResult> OnGetAsync(int? articleId)
        {
            if (articleId == null)
            {
                return NotFound();
            }

            Article = await _context.Articles.FirstOrDefaultAsync(m => m.Id == articleId);

            if (Article == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
