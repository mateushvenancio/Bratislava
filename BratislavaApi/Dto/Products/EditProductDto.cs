using System.ComponentModel.DataAnnotations;

namespace BratislavaApi.Dto.Products
{
    public class EditProductDto
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
        [Required]
        public bool Active { get; set; }
    }
}
