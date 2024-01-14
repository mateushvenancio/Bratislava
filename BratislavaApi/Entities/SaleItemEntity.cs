using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BratislavaApi.Entities
{
    public class SaleItemEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public ProductEntity Product { get; set; }
        [Required]
        public int Quantity { get; set; }

        public decimal Total
        {
            get
            {
                return Product.Total * Quantity;
            }
        }
    }
}
