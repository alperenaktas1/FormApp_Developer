using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UI.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string? Name { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Maksimum 10 karakter belirtiniz.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }
    }
}
