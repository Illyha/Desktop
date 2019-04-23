using Microsoft.AspNetCore.Identity;

namespace RequireConfirmedEmail.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string UnconfirmedEmail { get; set; }
    }
}
