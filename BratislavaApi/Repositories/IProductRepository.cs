using BratislavaApi.Dto.Products;
using BratislavaApi.Entities;

namespace BratislavaApi.Repositories
{
    public interface IProductRepository
    {
        public List<ProductEntity> GetAll();
        public ProductEntity GetById(int id);
        public ProductEntity Create(CreateProductDto dto);
        public ProductEntity Edit(EditProductDto dto);
        public void Delete(int id);
    }
}
