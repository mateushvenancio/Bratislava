using BratislavaApi.Dto.Categories;
using BratislavaApi.Entities;

namespace BratislavaApi.Repositories
{
    public interface ICategoriesRepository
    {
        public List<CategoryEntity> GetAll();
        public CategoryEntity GetById(int id);
        public CategoryEntity Create(CreateCategoryDto name);
        public CategoryEntity Edit(EditCategoryDto name);
        public void Delete(int id);
    }
}
