using Microsoft.AspNetCore.Identity;
namespace ShortListMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nickname { get; set; }
        public string? About { get; set; }
    }
}
