using EFcModelToSQLDB.Data;
using EFcModelToSQLDB.Models;

namespace EFcModelToSQLDB
{
    class Program
    {
        public static void Main(string[] args)
        {
            using var context = new MyPracticeDBContext();

            // Empty Products table.
            var products = context.Products.Where(p => p.Name != null);
            foreach (Product p in products)
            {
                if (p is not null)
                {
                    context.Products.Remove(p);
                }
            }
            context.SaveChanges();


            // Add new products
            Product[] newProducts =
            [
                new()
                {
                    Name = "Rope knot",
                    Price = 2.99m
                },
                new()
                {
                    Name = "Squeaky bone",
                    Price = 3.99m
                },
                new()
                {
                    Name = "Tennis ball - 3 pack",
                    Price = 9.99m
                }
            ];
            context.AddRange(newProducts);
            context.SaveChanges();

            // Update one product
            var squeakyBone = context.Products
            .Where(p => p.Name == "Squeaky bone")
            .FirstOrDefault();

            if (squeakyBone is not null)
            {
                squeakyBone.Price = 4.99m;
            }
            context.SaveChanges();


            // Pull products above specified price.
            var matchingProducts = context.Products
            .Where(p => p.Price > 4m)
            .OrderBy(p => p.Name);

            foreach (Product p in matchingProducts)
            {
                Console.WriteLine($"Id: {p.Id}");
                Console.WriteLine($"Name: {p.Name}");
                Console.WriteLine($"Price: {p.Price}");
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}