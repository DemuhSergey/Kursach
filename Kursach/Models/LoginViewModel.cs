using System.ComponentModel.DataAnnotations;

namespace Kursach.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Login is required")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Pasword is required")]
        [DataType(DataType.Password)]
        public string Pasword { get; set; }
    }
}