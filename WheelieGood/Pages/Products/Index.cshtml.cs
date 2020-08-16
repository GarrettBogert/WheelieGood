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
    public class IndexModel : PageModel
    {
        private readonly WheelieGood.Data.WheelieGoodDbContext _context;

        public IndexModel(WheelieGood.Data.WheelieGoodDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
