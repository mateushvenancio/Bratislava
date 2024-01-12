using BratislavaApi.Core.Validators;
using BratislavaApi.Entities;
using System.ComponentModel.DataAnnotations;

namespace BratislavaApi.Dto.Sales
{
    public class CreateSaleDto
    {
        [Required]
        [ListNotEmpty]
        public List<ProductEntity> Products { get; set; }
    }
}
