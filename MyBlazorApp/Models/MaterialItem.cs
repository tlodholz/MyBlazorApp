using System.Security.Cryptography;
using System.Text;

namespace MyBlazorApp.Models
{
    public class MaterialItem
    {
        public int? ProjectId;
        public string ProductNumber;
        public string Description;
        public string Category;
        public decimal Price;
        public int Quantity;
        public decimal Total;
        
        public MaterialItem () {
            ProductNumber = GenerateRandomProductNumber(10);
            Category = GenerateRandomCategory();
            Description = GenerateRandomDescription(this.Category);
            Price = GenerateRandomPrice(1, 200);
            Quantity = GenerateRandomNumber(1, 25);
            Total = Quantity * Price;
        }

        static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1); // max + 1 to include the max value
        }

        static string GenerateRandomProductNumber(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                stringBuilder.Append(chars[index]);
            }

            return stringBuilder.ToString();
        }

        static decimal GenerateRandomPrice(decimal min, decimal max)
        {
            Random random = new Random();
            // Generate a random double between min and max
            double randomDouble = random.NextDouble() * (double)(max - min) + (double)min;

            // Convert to decimal and round to 2 decimal places
            return Math.Round((decimal)randomDouble, 2);
        }

        static string GenerateRandomCategory()
        {
            List<string> list = new List<string>();
            list.Add("Lumber");
            list.Add("Flooring");
            list.Add("HVAC");
            list.Add("Plumbing");
            list.Add("Electrical");

            Random random = new Random();
            int index = random.Next(list.Count); // Generate a random index
            return list[index]; // Return the item at the random index
        }

        static string GenerateRandomDescription(string category)
        {
            // Define categories and their associated products
            Dictionary<string, List<string>> categoryProducts = new Dictionary<string, List<string>>()
            {
                { "Lumber", new List<string> { "Plywood", "Boards", "Decking", "Fencing", "Framing" } },
                { "Flooring", new List<string> { "Vinyl", "Tile", "Carpet", "Hardwood", "Rugs" } },
                { "HVAC", new List<string> { "Heaters", "Metal Ducts", "Register Boxes", "HVAC Tools", "Water Pumps" } },
                { "Plumbing", new List<string> { "Supply Lines", "Valves & Valve Repair", "Water Heaters", "Pipe & Fittings", "Outdoor Drainage" } },
                { "Electrical", new List<string> { "Batteries", "Conduit & Conduit Fittings", "Electrical Outlets & Plugs", "Cable & Wire Connectors", "Light Sockets & Adapters" } },
            };

            // Check if the category exists
            if (!categoryProducts.ContainsKey(category))
            {
                return "Category not found.";
            }

            // Get the list of products for the given category
            List<string> products = categoryProducts[category];
            Random random = new Random();

            // Select a random product from the list
            int index = random.Next(products.Count);
            return products[index];
        }

    }
}
