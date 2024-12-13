using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Slutuppgift.Views.Account;

public class EditUserVM
{
    [StringLength(30, ErrorMessage = "Maxlength 30")]
    public string? FirstName { get; set; }
    [StringLength(30, ErrorMessage = "Maxlength 30")]
    public string? LastName { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
}