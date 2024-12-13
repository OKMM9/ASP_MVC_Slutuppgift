namespace ASP_MVC_Slutuppgift.Models;

public class UserDto
{
    public string Id { get; set; }
    public string Username { get; set; } = null!;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
