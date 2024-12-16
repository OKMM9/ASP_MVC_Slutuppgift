using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Slutuppgift.Views.Account;

public class EditUserVM
{
    [StringLength(30, ErrorMessage = "Maxlength 30")]
    [Display(Prompt = "First Name")]
    public string? FirstName { get; set; }
    [StringLength(30, ErrorMessage = "Maxlength 30")]
    [Display(Prompt = "Last Name")]
    public string? LastName { get; set; }
    [EmailAddress]
    [Display(Prompt = "E-Mail")]
    public string? Email { get; set; }
}