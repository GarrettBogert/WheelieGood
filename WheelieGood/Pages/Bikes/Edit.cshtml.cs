using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WheelieGood.Core;
using WheelieGood.Data;

namespace WheelieGood.Pages.Bikes
{
    public class EditModel : PageModel
    {
        private readonly IBikeData bikeData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Bike Bike { get; set; }
        public IEnumerable<SelectListItem> Manufacturers { get; set; }
        public EditModel(IBikeData bikeData, IHtmlHelper htmlHelper)
        {
            this.bikeData = bikeData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int? bikeId)
        {
            Manufacturers = htmlHelper.GetEnumSelectList<Bike.BikeManufacturer>();
            if (bikeId.HasValue)
            {
                Bike = bikeData.GetById(bikeId.Value);
            }
            else
            {
                Bike = new Bike();
            }
            if(Bike == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {   
            if (!ModelState.IsValid)
            {
                Manufacturers = htmlHelper.GetEnumSelectList<Bike.BikeManufacturer>();
                return Page();
            }

            if(Bike.Id > 0)
            {
                bikeData.Update(Bike);
            }
            else
            {
                bikeData.Add(Bike);
            }
            
            bikeData.Commit();
            TempData["Message"] = "Bike saved!";
            return RedirectToPage($"./Detail", new { bikeId = Bike.Id, ResultMessage = "Bike saved" });

        }
    }
}