using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UI.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [Display(Name = "Ad")]
        [StringLength(20, MinimumLength = 3)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [StringLength(10, ErrorMessage = "Maksimum 10 karakter belirtiniz.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }
    }
}
