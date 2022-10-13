using System.ComponentModel.DataAnnotations;

namespace ReSell.Models
{
    public class Sellers
    {
        public int ID { get; set; }
        [StringLength(30, ErrorMessage = "Please enter your full name using 30 characters or less.")]
        public string Name { get; set; }
        [StringLength(50, ErrorMessage = "Please enter your address using 50 characters or less.")]
        public string City { get; set; }
        [StringLength(2, ErrorMessage = "Please enter the State using 2 characters.")]
        public string State { get; set; }
        [StringLength(10, ErrorMessage = "Zipcode has a maximum length of 10 numbers.")]
        public string Zip { get; set; }
        public string Email { get; set; }
        [Required]
        public int GarageSalesID { get; set; }
        public GarageSales GarageSales { get; set; }
        public int TradeID { get; set; }
        public Trade Trade { get; set; }
    }
}
