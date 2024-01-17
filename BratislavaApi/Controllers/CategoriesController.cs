using BratislavaApi.Dto.Categories;
using BratislavaApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BratislavaApi.Controllers
{
    [Route("/categories")]
    public class CategoriesController(ICategoriesRepository repository) : Controller
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
        public IActionResult Create([FromBody] CreateCategoryDto dto)
        {
            return Ok(repository.Create(dto));
        }

        [HttpPatch]
        public IActionResult Edit([FromBody] EditCategoryDto dto)
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
