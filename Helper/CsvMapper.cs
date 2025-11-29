using CSVfileCalculation.Model;
using CsvHelper.Configuration;

namespace CSVfileCalculation.Helper
{
    public sealed class CsvMapper : ClassMap<CsvData>
    {
        public CsvMapper()
        {
            Map(x => x.OrderId).Name("OrderId");
            Map(x => x.CustomerId).Name("CustomerId");
            Map(x => x.ProductIds).Name("ProductIds");
            Map(x => x.ProductName).Name("ProductName");
            Map(x => x.ProductCategory).Name("ProductCategory");
            Map(x => x.DateOfSale).Name("DateOfSale");
            Map(x => x.Region).Name("Region");
            Map(x => x.PaymentMethod).Name("PaymentMethod");
            Map(x => x.Quantity).Name("Quantity");
            Map(x => x.UnitPrice).Name("UnitPrice");
            Map(x => x.ShippingCost).Name("ShippingCost");
            Map(x => x.CustomerName).Name("CustomerName");
            Map(x => x.CustomerEmail).Name("CustomerEmail");
            Map(x => x.CustomerAddress).Name("CustomerAddress");
        }
    }
}
