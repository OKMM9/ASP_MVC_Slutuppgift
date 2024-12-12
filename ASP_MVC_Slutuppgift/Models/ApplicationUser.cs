using Microsoft.AspNetCore.Identity;

namespace ASP_MVC_Slutuppgift.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

}
