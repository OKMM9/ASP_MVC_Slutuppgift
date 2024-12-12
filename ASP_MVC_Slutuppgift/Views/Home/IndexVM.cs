namespace ASP_MVC_Slutuppgift.Views.Home;

public class IndexVM
{
    public required ICollection<CarItemsVM> CarItems { get; set; }
    public class CarItemsVM
    {
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
