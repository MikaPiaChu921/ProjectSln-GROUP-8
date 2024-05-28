using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class Migration10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Description", "Name", "Price", "RestaurantId", "Stock" },
                values: new object[,]
                {
                    { 7, "bla bla bla", "ambot", 100.0, 4, 200 },
                    { 8, "white, dark and milk", "chocolate", 100.0, 4, 200 },
                    { 9, "bla bla abla", "ambot", 100.0, 5, 200 },
                    { 10, "white, dark and milk", "chocolate", 100.0, 5, 200 }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "Description", "Locaton", "Name" },
                values: new object[,]
                {
                    { 4, "Enjoy nice food", "ambot", "Cyra" },
                    { 5, "Enjoy nice food", "ambot", "Paul" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5);
        }
    }
}
