using System.ComponentModel.DataAnnotations;

namespace BratislavaApi.Dto.Products
{
    public class CreateProductDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "Name must be at least 4 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "Description must be at least 4 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Category ID is required")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public bool Active { get; set; } = true;
    }
}
