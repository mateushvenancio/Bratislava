using BratislavaApi.Dto.Products;
using BratislavaApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BratislavaApi.Controllers
{
    [ApiController]
    [Route("/products")]
    public class ProductsController(IProductRepository repository) : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateProductDto dto)
        {
            return Ok(repository.Create(dto));
        }

        [HttpPatch]
        public IActionResult Edit([FromBody] EditProductDto dto)
        {
            return Ok(repository.Edit(dto));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok("Deleted!");
        }
    }
}
