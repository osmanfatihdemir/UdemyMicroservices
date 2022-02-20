using System.ComponentModel.DataAnnotations;

namespace FreeCourse.WebUI.Models.Orders
{
    public class CheckoutInfoInput
    {
        [Display(Name = "City")]
        public string Province { get; set; }

        [Display(Name = "District")]
        public string District { get; set; }

        [Display(Name = "Street")]
        public string Street { get; set; }

        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }

        [Display(Name = "Adress")]
        public string Line { get; set; }

        [Display(Name = "card name surname")]
        public string CardName { get; set; }

        [Display(Name = "Card number")]
        public string CardNumber { get; set; }

        [Display(Name = "expiry date (month/year)")]
        public string Expiration { get; set; }

        [Display(Name = "CVV/CVC2 number")]
        public string CVV { get; set; }
    }
}
