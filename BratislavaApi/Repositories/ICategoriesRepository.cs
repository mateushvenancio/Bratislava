using BratislavaApi.Dto.Categories;
using BratislavaApi.Entities;

namespace BratislavaApi.Repositories
{
    public interface ICategoriesRepository
    {
        public List<CategoryEntity> GetAll();
        public CategoryEntity GetById(int id);
        public CategoryEntity Create(CreateCategoryDto dto);
        public CategoryEntity Edit(EditCategoryDto dto);
        public void Delete(int id);
    }
}
