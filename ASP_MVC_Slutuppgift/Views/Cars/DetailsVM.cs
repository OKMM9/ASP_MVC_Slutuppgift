namespace ASP_MVC_Slutuppgift.Views.Cars;

public class DetailsVM
{
    public int Id { get; set; }
    public string Model { get; set; } = null!;
    public string LicensePlate { get; set; } = null!;
    public string? Description { get; set; }
    public string Category { get; set; } = null!;
}
