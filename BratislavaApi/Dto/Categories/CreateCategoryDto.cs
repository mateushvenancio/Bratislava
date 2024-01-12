using System.ComponentModel.DataAnnotations;

namespace BratislavaApi.Dto.Categories
{
    public class CreateCategoryDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "Name is required to have at least 4 length")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "Description is required to have at least 4 length")]
        public string Description { get; set; }
        public bool Active { get; set; } = true;
    }
}
