using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSVfileCalculation.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey(nameof(Order))]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(Order))]
        public int ProductIds { get; set; }
        public DateTime DateOfSale { get; set; }
        public string Region { get; set; }
        public string PaymentMethod { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal ShippingCost { get; set; }



        //        - **Region:**
        //- **Date of Sale:**
        //- **Quantity Sold:**
        //- **Unit Price:**
        //- **Discount:**
        //- **Shipping Cost:**
    }
}
