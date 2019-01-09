using System.ComponentModel.DataAnnotations;

namespace Kursach.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "FirstName is required")]
        public string Firstname { get; set; }
  
        [Required(ErrorMessage = "LastName is required")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Login is required")]
        public string Login { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pasword is required")]
        [DataType(DataType.Password)]
        public string Pasword { get; set; }
    }
}