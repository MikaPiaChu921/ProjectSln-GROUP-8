using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class Migration12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

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

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Description", "Name", "Price", "RestaurantId", "Stock" },
                values: new object[,]
                {
                    { 100, "Served with soya onion gravy, apple, and mustard leaf, this dish highlights Cebu’s reputation for pork dishes.", "Roasted Suckling Pork", 850.0, 1, 999 },
                    { 101, "A Filipino ceviche with shrimp, calamansi, pickled papaya, chili, and coconut, offering a fresh and tangy flavor profile.", "Truffle Mac & Cheese", 650.0, 1, 999 },
                    { 102, "This seafood dish is served in a bacon beer sauce, combining local seafood with rich, savory flavors.", "Local Red Mullet and Clams", 950.0, 1, 999 },
                    { 103, "A modern twist featuring jalapeno ice, adding a spicy and cool element to the fresh sashimi.", "Tuna Sashimi", 1200.0, 1, 999 },
                    { 104, "A A hearty and flavorful chicken dish, perfect for those looking for a substantial meal​", "Chicken Tomahawk", 450.0, 1, 999 },
                    { 200, "This signature dish features tender, flavorful baby back ribs smothered in a tangy barbecue sauce.", "Brian’s Ribs", 380.0, 2, 999 },
                    { 201, "A juicy steak served with mashed potatoes and vegetables, perfect for meat lovers.", "David Dean’s Tenderloin", 880.0, 2, 999 },
                    { 202, "A gigantic burger loaded with beef patties, cheese, bacon, and various toppings, ideal for sharing.", "Mighty Ton Burger", 520.0, 2, 999 },
                    { 203, "A creamy and savory pasta dish with grilled chicken and mushrooms.", "Tricia’s Pasta", 690.0, 2, 999 },
                    { 204, "A rich and decadent chocolate lava cake served with ice cream", "Lauren’s Lava Cake", 250.0, 2, 999 },
                    { 300, "The house specialty, featuring crispy skin and tender, flavorful meat, is a must-try.", "Lechon de Cebu", 550.0, 3, 999 },
                    { 301, "A stew made from leftover lechon, cooked with vinegar, liver sauce, and spices.", "Lechon Paksiw", 450.0, 3, 999 },
                    { 302, " A sizzling platter of chopped lechon mixed with onions, chili, and spices.", "Sizzling Lechon Sisig", 980.0, 3, 999 },
                    { 303, "A traditional Filipino sour soup with lechon, vegetables, and tamarind broth.", "Lechon Sinigang", 750.0, 3, 999 },
                    { 304, "Fried lechon served with a variety of dipping sauces for an extra crispy experience​.  ", "Pritchon", 280.0, 3, 999 },
                    { 400, "This dish features locally sourced organic chicken roasted to perfection with herbs and spices.", "Organic Roast Chicken", 890.0, 4, 999 },
                    { 401, "Fresh tuna seared and served with a tangy wasabi dressing and vegetables.", "Seared Tuna", 750.0, 4, 999 },
                    { 402, "A Filipino-Spanish fusion dish with slow-cooked lamb shank in a rich tomato-based stew.", "Lamb Shank Caldereta", 950.0, 4, 999 },
                    { 403, "A creamy risotto with pumpkin, goat cheese, and a hint of truffle oil.", "Pumpkin and Goat Cheese Risotto", 700.0, 4, 999 },
                    { 404, "A traditional Filipino dessert made with layers of graham crackers, cream, and fresh mangoes​", "Mango Float", 280.0, 4, 999 },
                    { 500, "A hearty breakfast platter featuring eggs, bacon, sausage, toast, and a side of greens.", "Brian’s Ribs", 450.0, 5, 999 },
                    { 501, "Creamy avocado spread on toasted artisanal bread, topped with cherry tomatoes, feta cheese, and a sprinkle of chili flakes. ", "David Dean’s Tenderloin", 350.0, 5, 999 },
                    { 502, "Poached eggs and smoked salmon on a toasted English muffin, drizzled with hollandaise sauce and served with a side salad", "Mighty Ton Burger", 480.0, 5, 999 },
                    { 503, "Fluffy pancakes served with maple syrup and butter, perfect for a sweet breakfast treat.", "Tricia’s Pasta", 320.0, 5, 999 },
                    { 504, "A flavorful dish of spicy chorizo sausage, potatoes, and bell peppers, topped with a fried egg.", "Lauren’s Lava Cake", 420.0, 5, 999 }
                });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1,
                column: "Locaton",
                value: "Cebu Business Park");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                column: "Locaton",
                value: "Ayala Cebu");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                column: "Locaton",
                value: "Robinsons Galleria Cebu");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "Abaca Baking Company is renowned for its artisanal bread, pastries, and hearty breakfast dishes. It's a cozy spot perfect for brunch with a menu that showcases fresh, locally sourced ingredients.", "Ayala Cebu", "Abaca Baking Company" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 504);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Description", "Name", "Price", "RestaurantId", "Stock" },
                values: new object[,]
                {
                    { 1, "Joyce Ice Cream", "Ice Cream", 10.0, 1, 999 },
                    { 2, "Masarap", "Lollipop", 2.0, 1, 500 },
                    { 3, "Lasagna", "Spaghetti", 10.0, 2, 200 },
                    { 4, "jollibee, Mcdo and kfc", "Chiken", 140.0, 2, 200 },
                    { 5, "yum, big mac, 4 cheese woper", "Burger", 150.0, 3, 200 },
                    { 6, "white, dark and milk", "chocolate", 100.0, 3, 200 },
                    { 7, "bla bla bla", "ambot", 100.0, 4, 200 },
                    { 8, "white, dark and milk", "chocolate", 100.0, 4, 200 },
                    { 9, "bla bla abla", "ambot", 100.0, 5, 200 },
                    { 10, "white, dark and milk", "chocolate", 100.0, 5, 200 }
                });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1,
                column: "Locaton",
                value: "MSY Tower, Pescadores Road, Cebu Business Park, Cebu City");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                column: "Locaton",
                value: "Cebu Business Park in Cebu City, Philippines");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                column: "Locaton",
                value: "General Maxilom Avenue corner Sergio Osmeña Boulevard, Brgy. Tejero, Cebu City, Philippines ");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "Description", "Locaton", "Name" },
                values: new object[] { "Vikings Luxury Buffet offers an extensive and lavish dining experience with a wide variety of dishes from different cuisines around the world. The buffet features stations for Filipino, Korean, Japanese, Greek, Italian, French, and Western food, along with dedicated dessert and drink sections. The spacious and modern interior can accommodate large groups, making it a popular choice for celebrations and gatherings.", "SM City Cebu, North Reclamation Area, Cebu City", "Vikings Luxury Buffet" });
        }
    }
}
