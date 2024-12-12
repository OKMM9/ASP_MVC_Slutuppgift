namespace ASP_MVC_Slutuppgift.Views.Cars;

public class CarIndexVM
{
    public required ICollection<CarItemsVM> CarItems {  get; set; }
    public string? Temp {  get; set; } 
    public class CarItemsVM
    {
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public string LicensePlate { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
