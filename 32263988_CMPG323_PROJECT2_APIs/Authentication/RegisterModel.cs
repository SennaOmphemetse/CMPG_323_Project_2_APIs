using System.ComponentModel.DataAnnotations;
namespace _32263988_CMPG323_PROJECT2_APIs.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "FirstName required")]
        public string FirstName
        {
            get;
            set;
        }

        [Required(ErrorMessage = "LastName required")]
        public string LastName
        {
            get;
            set;
        }

        [Required(ErrorMessage = "UserName required")]
        public string UserName
        {
            get;
            set;
        }

        [EmailAddress]
        [Required(ErrorMessage = "Email required")]
        public string Email
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Password is required")]
        public string Password
        {
            get;
            set;
        }
    }

}
