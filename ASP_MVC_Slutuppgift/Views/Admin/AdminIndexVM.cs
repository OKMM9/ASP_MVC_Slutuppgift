namespace ASP_MVC_Slutuppgift.Views.Admin;

public class AdminIndexVM
{
    public ICollection<UserListVM> Users { get; set; } = new List<UserListVM>();
    public class UserListVM
    {
        public string Id { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
    }
}