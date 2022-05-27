using Microsoft.AspNetCore.Identity;

namespace EcommerceKOgren.WebUI.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
