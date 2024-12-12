using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Slutuppgift.Views.Account;

public class RegisterVM
{
    [Required]
    public string Username { get; set; } = null!;
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
    [Required]
    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    [Display(Name = "Repeat Password")]
    public string PasswordRepeat { get; set; } = null!;
    public bool IsAdmin { get; set; }
}   