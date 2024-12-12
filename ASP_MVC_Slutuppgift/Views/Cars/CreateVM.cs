using ASP_MVC_Slutuppgift.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Slutuppgift.Views.Cars;

public class CreateVM
{
    [Required(ErrorMessage = "Model Required")]
    [StringLength(15, MinimumLength = 2, ErrorMessage = "Model must be between 2 and 10 characters.")]
    public string Model { get; set; } = null!;
    [Required(ErrorMessage = "License Plate Required")]
    [StringLength(10, MinimumLength = 2, ErrorMessage = "License plate number must be between 2 and 10 characters.")]
    public string LicensePlate { get; set; } = null!;
    [StringLength(250, ErrorMessage = "Description must be max 250 characters.")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Vehicle Type Required")]
    public int CategoryId { get; set; }
    public SelectListItem[]? CategoryList { get; set; } = null!;
}
