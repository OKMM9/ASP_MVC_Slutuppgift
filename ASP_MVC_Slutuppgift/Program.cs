using ASP_MVC_Slutuppgift.Models;
using ASP_MVC_Slutuppgift.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ASP_MVC_Slutuppgift;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        builder.Services.AddTransient<DataService>();
        builder.Services.AddTransient<AccountService>();
        builder.Services.AddTransient<StateService>();

        builder.Services.AddHttpContextAccessor();

        builder.Services.AddSession();

        var connString = builder.Configuration.GetConnectionString("DefaultConnection");


        builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(connString));


        builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
        {

            options.Password.RequiredLength = 6;
            options.Password.RequireNonAlphanumeric = true;
        })
            .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();


        builder.Services.ConfigureApplicationCookie(o => o.LoginPath = "/login");

        builder.Services.AddHttpClient();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseAuthentication();
        app.UseAuthorization();
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseSession();

        app.MapControllers();

        app.MapStaticAssets();

        app.Run();
    }
}
