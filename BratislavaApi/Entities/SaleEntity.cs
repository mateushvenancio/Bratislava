using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BratislavaApi.Entities
{
    public class SaleEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public List<SaleItemEntity> ProductItems { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public decimal Total
        {
            get
            {
                return ProductItems.Aggregate(0m, (total, atual) => total + atual.Total);
            }
        }
    }
}
