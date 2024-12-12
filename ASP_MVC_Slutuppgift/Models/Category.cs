namespace ASP_MVC_Slutuppgift.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public ICollection<Car> Cars { get; set; } = null!;
}
