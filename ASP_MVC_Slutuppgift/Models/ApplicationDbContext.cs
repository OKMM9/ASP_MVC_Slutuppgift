using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ASP_MVC_Slutuppgift.Models;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
    IdentityDbContext<ApplicationUser, IdentityRole, string>(options)
{
    public required DbSet<Car> Cars { get; set; }
    public required DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Behövs när vi ärver från IdentityDbContext...
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Sedan", Description = "A sedan is a passenger car with a separate trunk and four doors." },
                new Category { Id = 2, Name = "SUV", Description = "An SUV (Sport Utility Vehicle) is a larger vehicle designed for both on-road and off-road driving, often with a higher ground clearance." },
                new Category { Id = 3, Name = "Hatchback", Description = "A hatchback is a car with a rear door that swings upward, offering more space in the trunk area." },
                new Category { Id = 4, Name = "Coupe", Description = "A coupe is a two-door car, typically sporty, with a fixed roof and a focus on style and performance." },
                new Category { Id = 5, Name = "Station Wagon", Description = "A station wagon is a car with an extended rear area for cargo, usually with a rear hatch or tailgate." },
                new Category { Id = 6, Name = "Minivan", Description = "A minivan is a vehicle designed for transporting families, with multiple rows of seats and a spacious interior." },
                new Category { Id = 7, Name = "Pickup", Description = "A pickup truck is a vehicle with an open cargo area and a cab for seating, commonly used for transporting goods and heavy loads." }
                );

        modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Model = "Toyota Camry", LicensePlate = "ABC12A", Description = "A popular mid-size sedan known for its comfort and reliability.", CategoryId = 1 },
                new Car { Id = 2, Model = "BMW 3 Series", LicensePlate = "GHI56C", Description = "A luxury sedan combining sportiness and elegance.", CategoryId = 1 },
                new Car { Id = 3, Model = "Kia Optima", LicensePlate = "BCD90J", Description = "A well-equipped mid-size sedan with a smooth drive and attractive design.", CategoryId = 1 },
                new Car { Id = 4, Model = "Mazda CX-5", LicensePlate = "ZAB56R", Description = "A stylish compact SUV with a premium feel and solid performance.", CategoryId = 2 },
                new Car { Id = 5, Model = "Hyundai Tucson", LicensePlate = "CDE78S", Description = "A compact and affordable SUV with a comfortable ride and tech features.", CategoryId = 2 },
                new Car { Id = 6, Model = "Volkswagen Golf", LicensePlate = "IJK12U", Description = "A compact hatchback with a reputation for quality, efficiency, and fun driving.", CategoryId = 3 },
                new Car { Id = 7, Model = "Honda Civic Hatchback", LicensePlate = "LMN34V", Description = "A sporty and practical hatchback with a comfortable interior and great handling.", CategoryId = 3 },
                new Car { Id = 8, Model = "Toyota Yaris", LicensePlate = "RST78X", Description = "A compact hatchback with low running costs and great reliability.", CategoryId = 3 },
                new Car { Id = 9, Model = "Ford Mustang", LicensePlate = "MNO12E", Description = "A classic American muscle car known for its powerful engine and sporty design.", CategoryId = 4 },
                new Car { Id = 10, Model = "Chevrolet Camaro", LicensePlate = "PQR34F", Description = "A high-performance coupe with bold styling and impressive acceleration.", CategoryId = 4 },
                new Car { Id = 11, Model = "Porsche 911", LicensePlate = "BCD12J", Description = "A high-performance luxury coupe with iconic styling and remarkable handling.", CategoryId = 4 },
                new Car { Id = 12, Model = "Volvo V90", LicensePlate = "QRS12O", Description = "A luxury station wagon offering excellent space, safety, and Swedish craftsmanship.", CategoryId = 5 },
                new Car { Id = 13, Model = "Subaru Outback", LicensePlate = "TUV34P", Description = "A rugged station wagon with all-wheel drive, great for off-road adventures.", CategoryId = 5 },
                new Car { Id = 14, Model = "Volkswagen Golf SportWagen", LicensePlate = "ABC90S", Description = "A practical and spacious station wagon with efficient fuel economy.", CategoryId = 5 }
                );
        modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" }
                );
    }
}