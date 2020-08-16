using System.ComponentModel.DataAnnotations;

namespace WheelieGood.Core
{
    public class WebImage
    {     
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
    }
}