using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Slutuppgift.Views.Account;

public class LoginVM
{
    [Required]
    [Display(Prompt = "Enter Username")] // Prompt blir "placeholder"
    public string Username { get; set; } = null!;

    [Required]
    [Display(Prompt = "Enter Password")] 
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
}
