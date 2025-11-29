using CSVfileCalculation.Model;
using CsvHelper;
using Microsoft.Extensions.Logging;
using System.Globalization;
using System.Text;

namespace CSVfileCalculation.Helper
{
    public class OrderHelper
    {
        public async Task<List<dynamic>> GetCsvData(string folderLocation)
        {
            CsvData csvData = new CsvData();
            using (var reader = new StreamReader(folderLocation, Encoding.Default))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<dynamic>().ToList();
                    await csv.ReadAsync();
                    csv.ReadHeader();
                    while (await csv.ReadAsync())
                    {
                        var orderid = csv.GetField("Order Id");
                        var productId = csv.GetField("Product ID");
                        var customerId = csv.GetField("Customer ID");
                        var productName = csv.GetField("Product Name");
                        var category = csv.GetField("Category");
                        var date = csv.GetField("Date of Sale");
                        var quantity = csv.GetField("Quantity Sold");
                        var price = csv.GetField("Unit Price");
                        var discount = csv.GetField("Discount");


                        csvData = new CsvData
                        {
                            OrderId = int.Parse(orderid),
                            ProductIds = int.Parse(productId)

                        };
                    }
                    foreach (var record in records)
                    {
                        csvData = new CsvData
                        {
                            OrderId = int.Parse(record.OrderId),
                            ProductIds = int.Parse(record.ProductId)

                        };
                    }

                    return records;
                }
            }
        }
    }
}
