using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WheelieGood.Core;
using WheelieGood.Data;

namespace WheelieGood.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly WheelieGood.Data.WheelieGoodDbContext _context;

        public DetailsModel(WheelieGood.Data.WheelieGoodDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
