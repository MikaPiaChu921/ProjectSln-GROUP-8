using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class Migration8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "RestaurantId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Description", "Name", "Price", "RestaurantId", "Stock" },
                values: new object[,]
                {
                    { 4, "jollibee, Mcdo and kfc", "Chiken", 140.0, 2, 200 },
                    { 5, "yum, big mac, 4 cheese woper", "Burger", 150.0, 3, 200 },
                    { 6, "white, dark and milk", "chocolate", 100.0, 3, 200 }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "Description", "Locaton", "Name" },
                values: new object[,]
                {
                    { 2, "Enjoy nice food", "Tabunok", "Pia Restobar1" },
                    { 3, "Enjoy nice food", "Tabunok", "Pia Restobar2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ReservationDate",
                table: "Reservation");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "RestaurantId",
                value: 1);
        }
    }
}
