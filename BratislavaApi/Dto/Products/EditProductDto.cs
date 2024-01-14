using System.ComponentModel.DataAnnotations;

namespace BratislavaApi.Dto.Products
{
    public class EditProductDto
    {
        [Required]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public decimal? Price { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public bool? Active { get; set; }
    }
}
