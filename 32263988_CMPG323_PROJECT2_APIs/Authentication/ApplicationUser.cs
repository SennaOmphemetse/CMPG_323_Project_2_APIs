using Microsoft.AspNetCore.Identity;
namespace _32263988_CMPG323_PROJECT2_APIs.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
