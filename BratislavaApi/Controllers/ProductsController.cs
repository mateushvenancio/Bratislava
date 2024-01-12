using BratislavaApi.Dto.Products;
using Microsoft.AspNetCore.Mvc;

namespace BratislavaApi.Controllers
{
    [Route("/products")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            Console.WriteLine("Passou aqui!");
            return Ok("Retornando!");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) { return Ok("Retornando! " + id); }

        [HttpPost]
        public IActionResult Create([FromBody] CreateProductDto dto) { return Ok("Retornando! " + dto); }

        [HttpPatch]
        public IActionResult Edit([FromBody] EditProductDto dto) { return Ok("Produto dto " + dto); }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) { return Ok("Deletando " + id); }
    }
}
