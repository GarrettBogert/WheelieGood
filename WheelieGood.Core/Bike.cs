using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WheelieGood.Core
{
    public partial class Bike
    {
        public int Id { get; set; }
        public BikeManufacturer Make { get; set; }
        [Required]
        public string Model { get; set; }
        public int Wet_Weight { get; set; }
        public int HP { get; set; }
        public WebImage MainImage { get; set; }
        public IEnumerable<WebImage> SecondaryImages { get; set; }
    }
}
