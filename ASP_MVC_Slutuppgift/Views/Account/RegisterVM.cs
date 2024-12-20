﻿using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Slutuppgift.Views.Account;

public class RegisterVM
{
    [Required]
    [StringLength(25, ErrorMessage = "Maxlength 25")]
    [Display(Prompt = "Enter Username")]
    public string Username { get; set; } = null!;
    [Required]
    [DataType(DataType.Password)]
    [Display(Prompt = "Enter Password")]
    public string Password { get; set; } = null!;
    [Required]
    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    [Display(Name = "Repeat Password", Prompt ="Repeat Password")]
    public string PasswordRepeat { get; set; } = null!;
    public bool IsAdmin { get; set; }
}   