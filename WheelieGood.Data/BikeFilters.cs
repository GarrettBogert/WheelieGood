using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WheelieGood.Data
{
    class BikeFilters
    {
        Dictionary<string, List<string>> filters;

        void init()
        {
            filters.Add("Gears", new List<string> { "3", "4", "5", "6" });
            filters.Add("Weight", new List<string> { "Under 200", "200-230", "230-250", "250-300", "300+" });           
            filters.Add("Carbureted", null);
        }
    }
}
