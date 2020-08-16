using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WheelieGood.Core;
using WheelieGood.Data;

namespace WheelieGood.Pages.Bikes
{
    public class DeleteModel : PageModel
    {
        private readonly IBikeData bikeData;

        public Bike Bike { get; set; }
        public DeleteModel(IBikeData bikeData)
        {
            this.bikeData = bikeData;
        }
        public IActionResult OnGet(int bikeId)
        {
            Bike = bikeData.GetById(bikeId);
            if(Bike == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(int bikeId)
        {
            var bike = bikeData.Delete(bikeId);
            bikeData.Commit();

            if(bike == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{bike.Model} deleted";
            return RedirectToPage("./List");
        }
    }
}