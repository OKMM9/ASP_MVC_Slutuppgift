using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP_MVC_Slutuppgift.Migrations
{
    /// <inheritdoc />
    public partial class addedHasDataOnCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A sedan is a passenger car with a separate trunk and four doors.", "Sedan" },
                    { 2, "An SUV (Sport Utility Vehicle) is a larger vehicle designed for both on-road and off-road driving, often with a higher ground clearance.", "SUV" },
                    { 3, "A hatchback is a car with a rear door that swings upward, offering more space in the trunk area.", "Hatchback" },
                    { 4, "A coupe is a two-door car, typically sporty, with a fixed roof and a focus on style and performance.", "Coupe" },
                    { 5, "A station wagon is a car with an extended rear area for cargo, usually with a rear hatch or tailgate.", "Station Wagon" },
                    { 6, "A minivan is a vehicle designed for transporting families, with multiple rows of seats and a spacious interior.", "Minivan" },
                    { 7, "A pickup truck is a vehicle with an open cargo area and a cab for seating, commonly used for transporting goods and heavy loads.", "Pickup" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
