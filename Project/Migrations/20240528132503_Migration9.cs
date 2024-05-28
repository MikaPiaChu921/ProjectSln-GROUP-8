using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class Migration9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "Locaton", "Name" },
                values: new object[] { "San Isidro", "Jayharron" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "Locaton", "Name" },
                values: new object[] { "Tisa", "Aubrey" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "Locaton", "Name" },
                values: new object[] { "Tabunok", "Pia Restobar1" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "Locaton", "Name" },
                values: new object[] { "Tabunok", "Pia Restobar2" });
        }
    }
}
