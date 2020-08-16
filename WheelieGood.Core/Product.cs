using System;
using System.Collections.Generic;
using System.Text;

namespace WheelieGood.Core
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsUniversal { get; set; }
        public string Brand { get; set; }
        public int Weight { get; set; }
        public WebImage MainImage { get; set; }
        public IEnumerable<WebImage> SecondaryImages { get; set; }
    }
}
