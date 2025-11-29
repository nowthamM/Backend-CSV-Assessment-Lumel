using System.ComponentModel.DataAnnotations;

namespace CSVfileCalculation.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public string ProductCategory { get; set; }
    }
}
