using System.ComponentModel.DataAnnotations;

namespace WAD2_Website.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please Enter a User ID")]
        [Range(1, 10)]
        public int? UserId { get; set; }

        [Required(ErrorMessage = "Please Enter a First Name")]
        public string UserFirstName { get; set; }

        [Required(ErrorMessage = "Please Enter a Last Name")]
        public string UserLastName { get; set; }

        [Required(ErrorMessage = "Please Enter a Password")]
        public string Password { get; set; }
    }
}