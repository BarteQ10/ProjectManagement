using Microsoft.AspNetCore.Identity;

namespace ProjectManagement.Data.Data_Contex
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
