using Microsoft.AspNetCore.Mvc;
using WheelieGood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelieGood.Pages.ViewComponents
{
    public class BikeCountViewComponent : ViewComponent
    {
        private readonly IBikeData data;

        public BikeCountViewComponent(IBikeData data)
        {
            this.data = data;
        }

        public IViewComponentResult Invoke()
        {
            var count = data.GetCount();
            return View(count);
        }
    }
}
