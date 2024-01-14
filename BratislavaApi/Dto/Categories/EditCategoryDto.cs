using System.ComponentModel.DataAnnotations;

namespace BratislavaApi.Dto.Categories
{
    public class EditCategoryDto
    {
        [Required]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public bool? Active { get; set; }
    }
}
