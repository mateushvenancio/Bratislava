using System.ComponentModel.DataAnnotations;

namespace BratislavaApi.Dto.Products
{
    public class CreateProductDto
    {
        [Required]
        [StringLength(255, MinimumLength = 4)]
        public string Name { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 4)]
        public string Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public bool Active { get; set; } = true;
    }
}
