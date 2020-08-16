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
    public class DetailModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public Bike Bike { get; set; }
        public IBikeData BikeData;

        public DetailModel(IBikeData bikeData)
        {
            BikeData = bikeData;
        }
        public IActionResult OnGet(int bikeId)
        {
            Bike = BikeData.GetById(bikeId);   
            if(Bike == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}