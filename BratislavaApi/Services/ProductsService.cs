using BratislavaApi.DbContexts;
using BratislavaApi.Dto.Products;
using BratislavaApi.Entities;
using BratislavaApi.Repositories;

namespace BratislavaApi.Services
{
    public class ProductsService(PostgresDbContext context) : IProductRepository
    {
        public ProductEntity Create(CreateProductDto dto)
        {
            var category = context.Categories.Find(dto.CategoryId) ?? throw new NotImplementedException();
            var product = new ProductEntity()
            {
                Name = dto.Name,
                Description = dto.Description,
                CreatedAt = DateTime.Now,
                Category = category,
                Price = dto.Price,
                DiscountPercentage = dto.DiscountPercentage,
                Active = dto.Active,
            };
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }

        public void Delete(int id)
        {
            context.Remove(context.Products.Single(p => p.Id == id));
            context.SaveChanges();
        }

        public ProductEntity Edit(EditProductDto dto)
        {
            var oldProduct = context.Products.Find(dto.Id) ?? throw new NotImplementedException();
            CategoryEntity? newCategory;

            if (dto.CategoryId == null || oldProduct.Category.Id == dto.CategoryId)
            {
                newCategory = oldProduct.Category;
            }
            else
            {
                newCategory = context.Categories.Find(dto.CategoryId);
            }

            if (newCategory == null) { throw new NotImplementedException(); }

            var editedProduct = new ProductEntity()
            {
                Active = dto.Active ?? oldProduct.Active,
                Description = dto.Description ?? oldProduct.Description,
                DiscountPercentage = dto.DiscountPercentage ?? oldProduct.DiscountPercentage,
                Name = dto.Name ?? oldProduct.Name,
                Price = dto.Price ?? oldProduct.Price,
                Category = newCategory,
            };

            context.Products.Update(editedProduct);
            context.SaveChanges();

            return editedProduct;
        }

        public List<ProductEntity> GetAll()
        {
            return context.Products.ToList();
        }

        public ProductEntity GetById(int id)
        {
            return context.Products.Find(id) ?? throw new NotImplementedException();
        }
    }
}
