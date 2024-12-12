﻿// <auto-generated />
using System;
using ASP_MVC_Slutuppgift.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP_MVC_Slutuppgift.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241212101627_addedHasDataOnCar")]
    partial class addedHasDataOnCar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP_MVC_Slutuppgift.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ASP_MVC_Slutuppgift.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A popular mid-size sedan known for its comfort and reliability.",
                            LicensePlate = "ABC12A",
                            Model = "Toyota Camry"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A luxury sedan combining sportiness and elegance.",
                            LicensePlate = "GHI56C",
                            Model = "BMW 3 Series"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "A well-equipped mid-size sedan with a smooth drive and attractive design.",
                            LicensePlate = "BCD90J",
                            Model = "Kia Optima"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "A stylish compact SUV with a premium feel and solid performance.",
                            LicensePlate = "ZAB56R",
                            Model = "Mazda CX-5"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "A compact and affordable SUV with a comfortable ride and tech features.",
                            LicensePlate = "CDE78S",
                            Model = "Hyundai Tucson"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "A compact hatchback with a reputation for quality, efficiency, and fun driving.",
                            LicensePlate = "IJK12U",
                            Model = "Volkswagen Golf"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "A sporty and practical hatchback with a comfortable interior and great handling.",
                            LicensePlate = "LMN34V",
                            Model = "Honda Civic Hatchback"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "A compact hatchback with low running costs and great reliability.",
                            LicensePlate = "RST78X",
                            Model = "Toyota Yaris"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 4,
                            Description = "A classic American muscle car known for its powerful engine and sporty design.",
                            LicensePlate = "MNO12E",
                            Model = "Ford Mustang"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 4,
                            Description = "A high-performance coupe with bold styling and impressive acceleration.",
                            LicensePlate = "PQR34F",
                            Model = "Chevrolet Camaro"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 4,
                            Description = "A high-performance luxury coupe with iconic styling and remarkable handling.",
                            LicensePlate = "BCD12J",
                            Model = "Porsche 911"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 5,
                            Description = "A luxury station wagon offering excellent space, safety, and Swedish craftsmanship.",
                            LicensePlate = "QRS12O",
                            Model = "Volvo V90"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 5,
                            Description = "A rugged station wagon with all-wheel drive, great for off-road adventures.",
                            LicensePlate = "TUV34P",
                            Model = "Subaru Outback"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 5,
                            Description = "A practical and spacious station wagon with efficient fuel economy.",
                            LicensePlate = "ABC90S",
                            Model = "Volkswagen Golf SportWagen"
                        });
                });

            modelBuilder.Entity("ASP_MVC_Slutuppgift.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A sedan is a passenger car with a separate trunk and four doors.",
                            Name = "Sedan"
                        },
                        new
                        {
                            Id = 2,
                            Description = "An SUV (Sport Utility Vehicle) is a larger vehicle designed for both on-road and off-road driving, often with a higher ground clearance.",
                            Name = "SUV"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A hatchback is a car with a rear door that swings upward, offering more space in the trunk area.",
                            Name = "Hatchback"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A coupe is a two-door car, typically sporty, with a fixed roof and a focus on style and performance.",
                            Name = "Coupe"
                        },
                        new
                        {
                            Id = 5,
                            Description = "A station wagon is a car with an extended rear area for cargo, usually with a rear hatch or tailgate.",
                            Name = "Station Wagon"
                        },
                        new
                        {
                            Id = 6,
                            Description = "A minivan is a vehicle designed for transporting families, with multiple rows of seats and a spacious interior.",
                            Name = "Minivan"
                        },
                        new
                        {
                            Id = 7,
                            Description = "A pickup truck is a vehicle with an open cargo area and a cab for seating, commonly used for transporting goods and heavy loads.",
                            Name = "Pickup"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ASP_MVC_Slutuppgift.Models.Car", b =>
                {
                    b.HasOne("ASP_MVC_Slutuppgift.Models.Category", "Categories")
                        .WithMany("Cars")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ASP_MVC_Slutuppgift.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ASP_MVC_Slutuppgift.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_MVC_Slutuppgift.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ASP_MVC_Slutuppgift.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP_MVC_Slutuppgift.Models.Category", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
