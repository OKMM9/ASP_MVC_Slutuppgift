using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Slutuppgift.Views.Account;

public class LoginVM
{
    [Required]
    public string Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
