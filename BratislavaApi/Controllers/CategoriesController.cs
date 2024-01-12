using BratislavaApi.Dto.Categories;
using Microsoft.AspNetCore.Mvc;

namespace BratislavaApi.Controllers
{
    [Route("/categories")]
    public class CategoriesController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Retorna todos");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok("Retorna by id");
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateCategoryDto dto)
        {
            Console.WriteLine("Dto: " + dto);
            return Ok("Criou" + dto);
        }

        [HttpPatch]
        public IActionResult Edit([FromBody] EditCategoryDto dto)
        {
            Console.WriteLine("Edit Dto: " + dto);
            return Ok("Retorna by id");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Console.WriteLine("Delete id: " + id);
            return Ok("Retorna by id");
        }
    }
}
