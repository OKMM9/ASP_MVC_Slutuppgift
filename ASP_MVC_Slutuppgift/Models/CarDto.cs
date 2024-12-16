namespace ASP_MVC_Slutuppgift.Models;

public class CarDto
{
    public int Id { get; set; }
    public string Model { get; set; } = null!;
    public string LicensePlate { get; set; } = null!;
    public string? Description { get; set; }
    public Category Category { get; set; } = null!;
}
