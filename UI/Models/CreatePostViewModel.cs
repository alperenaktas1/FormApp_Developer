using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class CreatePostViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Yapılış tarihi")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Display(Name = "Yapan kişi")]
        public int CreatedBy { get; set; }
    }
}
