using System.ComponentModel.DataAnnotations;

namespace CMPG323_PROJECT2_APIs.Authentication
{
    public class UserSignUP
    {
        [Required(ErrorMessage = "FirstName required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "UserName required")]
        public string Username{get; set;}

        [EmailAddress]
        [Required(ErrorMessage = "EmailAddress required")]
        public string Email {get;set;}


        [Required(ErrorMessage = "Password required")]
        public string Password {get; set;}

    }
}
