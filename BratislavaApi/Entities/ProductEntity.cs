using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BratislavaApi.Entities
{
    public class ProductEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public CategoryEntity Category { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? DiscountPercentage { get; set; }
        [Required]
        public bool Active { get; set; } = true;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public decimal Total
        {
            get
            {
                var discount = Price * ((DiscountPercentage ?? 0) / 100);
                return Price - discount;
            }
        }
    }
}
