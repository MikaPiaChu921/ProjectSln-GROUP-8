using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class Migration11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "The Pig & Palm offers a contemporary dining experience with a focus on European and gastropub cuisine. Founded by Michelin-starred British chef Jason Atherton and his Cebuana wife Irha, the restaurant features a modern, stylish interior with a relaxed atmosphere. The menu emphasizes locally sourced ingredients and innovative dishes, making it a popular spot for both brunch and dinner. Signature dishes include their creative takes on classic pub fare and a variety of cocktails crafted to perfection.", "MSY Tower, Pescadores Road, Cebu Business Park, Cebu City", "The Pig & Palm" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "This family-owned restaurant offers a mix of Spanish and American dishes in a cozy, homey setting. The most popular dish is their Baby Back Ribs, which are renowned for their generous portions and delicious flavor​", "Cebu Business Park in Cebu City, Philippines", "Casa Verde" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "House of Lechon specializes in the iconic Cebuano lechon, a traditional roasted pig known for its crispy skin and savory meat. The restaurant brings the renowned flavor of Carcar's lechon to the city, offering a taste of this beloved regional delicacy without the need for a long drive. The dining experience is enhanced by a casual, family-friendly atmosphere, perfect for enjoying authentic Filipino cuisine.", "General Maxilom Avenue corner Sergio Osmeña Boulevard, Brgy. Tejero, Cebu City, Philippines ", "House of Lechon" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "Located in a beautifully restored colonial home, Circa 1900 combines historical charm with modern culinary excellence. The restaurant's ambiance is both vintage and sophisticated, providing a unique setting for dining. The menu features international dishes with a focus on local ingredients, skillfully prepared by their talented chefs. This makes Circa 1900 an ideal venue for intimate dinners and special occasions.", "Sanjercas Ville Ext. Rd, Cebu City​", "Circa 1900" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "Vikings Luxury Buffet offers an extensive and lavish dining experience with a wide variety of dishes from different cuisines around the world. The buffet features stations for Filipino, Korean, Japanese, Greek, Italian, French, and Western food, along with dedicated dessert and drink sections. The spacious and modern interior can accommodate large groups, making it a popular choice for celebrations and gatherings.", "SM City Cebu, North Reclamation Area, Cebu City", "Vikings Luxury Buffet" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "Enjoy nice food", "Tabunok", "Pia Restobar" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "Enjoy nice food", "San Isidro", "Jayharron" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "Enjoy nice food", "Tisa", "Aubrey" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "Enjoy nice food", "ambot", "Cyra" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "Enjoy nice food", "ambot", "Paul" });
        }
    }
}
