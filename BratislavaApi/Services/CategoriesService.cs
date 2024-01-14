using BratislavaApi.DbContexts;
using BratislavaApi.Dto.Categories;
using BratislavaApi.Entities;
using BratislavaApi.Repositories;

namespace BratislavaApi.Services
{
    public class CategoriesService(PostgresDbContext context) : ICategoriesRepository
    {
        public CategoryEntity Create(CreateCategoryDto dto)
        {
            CategoryEntity category = new()
            {
                Active = true,
                Name = dto.Name,
                Description = dto.Description,
                CreatedAt = DateTime.Now,
            };
            context.Categories.Add(category);
            context.SaveChanges();
            return category;
        }

        public void Delete(int id)
        {
            var category = context.Categories.Find(id);
            if (category == null) { return; }
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public CategoryEntity Edit(EditCategoryDto dto)
        {
            var category = context.Categories.Find(dto.Id) ?? throw new NotImplementedException();
            CategoryEntity editedCategory = new()
            {
                Id = dto.Id,
                Active = dto.Active ?? category.Active,
                Name = dto.Name ?? category.Name,
                Description = dto.Description ?? category.Description,
            };
            context.Categories.Update(editedCategory);
            context.SaveChanges();
            return editedCategory;
        }

        public List<CategoryEntity> GetAll()
        {
            return context.Categories.ToList();
        }

        public CategoryEntity GetById(int id)
        {
            return context.Categories.Find(id) ?? throw new NotImplementedException();
        }
    }
}
