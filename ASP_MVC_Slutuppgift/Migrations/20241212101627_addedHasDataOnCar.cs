using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP_MVC_Slutuppgift.Migrations
{
    /// <inheritdoc />
    public partial class addedHasDataOnCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Description", "LicensePlate", "Model" },
                values: new object[,]
                {
                    { 1, 1, "A popular mid-size sedan known for its comfort and reliability.", "ABC12A", "Toyota Camry" },
                    { 2, 1, "A luxury sedan combining sportiness and elegance.", "GHI56C", "BMW 3 Series" },
                    { 3, 1, "A well-equipped mid-size sedan with a smooth drive and attractive design.", "BCD90J", "Kia Optima" },
                    { 4, 2, "A stylish compact SUV with a premium feel and solid performance.", "ZAB56R", "Mazda CX-5" },
                    { 5, 2, "A compact and affordable SUV with a comfortable ride and tech features.", "CDE78S", "Hyundai Tucson" },
                    { 6, 3, "A compact hatchback with a reputation for quality, efficiency, and fun driving.", "IJK12U", "Volkswagen Golf" },
                    { 7, 3, "A sporty and practical hatchback with a comfortable interior and great handling.", "LMN34V", "Honda Civic Hatchback" },
                    { 8, 3, "A compact hatchback with low running costs and great reliability.", "RST78X", "Toyota Yaris" },
                    { 9, 4, "A classic American muscle car known for its powerful engine and sporty design.", "MNO12E", "Ford Mustang" },
                    { 10, 4, "A high-performance coupe with bold styling and impressive acceleration.", "PQR34F", "Chevrolet Camaro" },
                    { 11, 4, "A high-performance luxury coupe with iconic styling and remarkable handling.", "BCD12J", "Porsche 911" },
                    { 12, 5, "A luxury station wagon offering excellent space, safety, and Swedish craftsmanship.", "QRS12O", "Volvo V90" },
                    { 13, 5, "A rugged station wagon with all-wheel drive, great for off-road adventures.", "TUV34P", "Subaru Outback" },
                    { 14, 5, "A practical and spacious station wagon with efficient fuel economy.", "ABC90S", "Volkswagen Golf SportWagen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
