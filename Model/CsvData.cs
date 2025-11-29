using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CSVfileCalculation.Model
{
    public class CsvData
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductIds { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public DateTime DateOfSale { get; set; }
        public string Region { get; set; }
        public string PaymentMethod { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal ShippingCost { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
    }
}
