using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using WheelieGood.Core;
using WheelieGood.Data;

namespace WheelieGood.Pages.Bikes
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IBikeData bike;
        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public string Message { get; set; }
        public List<Bike> Bikes { get; set; }
        public ListModel(IConfiguration config, IBikeData bike)
        {
            this.config = config;
            this.bike = bike;
        }
        public void OnGet()
        {          
            Message = config["Message"];
            Bikes = bike.GetBikesByModel(SearchTerm).ToList();
        }
    }
}
