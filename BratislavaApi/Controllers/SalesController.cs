using BratislavaApi.Dto.Sales;
using Microsoft.AspNetCore.Mvc;

namespace BratislavaApi.Controllers
{
    public class SalesController : Controller
    {
        [HttpPost]
        public IActionResult RegisterSale([FromBody] CreateSaleDto dto)
        {
            return Ok("");
        }

        [HttpGet("{id}")]
        public IActionResult GetSaleById(int id) { return Ok(""); }

        [HttpGet]
        public IActionResult GetSales() { return Ok(""); }
    }
}
