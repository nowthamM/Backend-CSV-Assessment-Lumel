using CSVfileCalculation.Db;
using CSVfileCalculation.Helper;
using CSVfileCalculation.Model;
using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text;

namespace CSVfileCalculation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderDbContext _orderDbContext;
        private readonly ILogger _logger;
        public OrderController(OrderDbContext orderDbContext, ILogger<OrderController> logger)
        {
            _orderDbContext = orderDbContext;
            _logger = logger;
        }
        [Route("Save")]
        [HttpPost]
        public IActionResult CreateOrder(List<Order> order)
        {
            foreach (var item in order)
            {
                _orderDbContext.Add(item);
                _orderDbContext.SaveChanges();
            }
            return Ok(order);
        }
        [Route("GetCsv")]
        [HttpPost]
        public Task<List<dynamic>> ReadCsvData(string folderLocation)
        {
            try
            {
                OrderHelper orderHelper = new OrderHelper();
                return orderHelper.GetCsvData(folderLocation);

            }
            catch (Exception ex) 
            {
                _logger.LogInformation("Exception at ReadCsvData -"+ex.Message);
                return null;
            }
        }
    }
}
