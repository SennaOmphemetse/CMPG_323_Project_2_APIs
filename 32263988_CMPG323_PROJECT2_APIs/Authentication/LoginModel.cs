using System.ComponentModel.DataAnnotations;
namespace _32263988_CMPG323_PROJECT2_APIs.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage = "UserName required")]
        public string Username
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Password required")]
        public string Password
        {
            get;
            set;
        }
    }

}
