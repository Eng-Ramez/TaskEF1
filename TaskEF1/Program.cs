using TaskEF1.Data;
using TaskEF1.Models;

namespace TaskEF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var product1 = new List<Product>
            {
                new Product {  Name = "Laptop", Price = 1200.00, Description = "High performance laptop", Rate = 5 },
                new Product {  Name = "Novel", Price = 15.99, Description = "Fiction book", Rate = 2 },
                new Product {  Name = "T-Shirt", Price = 9.99, Description = "Cotton t-shirt", Rate = 4 },
                new Product {  Name = "Blender", Price = 49.50, Description = "Kitchen blender", Rate = 3 },
                new Product {  Name = "Headphones", Price = 89.99, Description = "Noise-cancelling", Rate = 9 }
            };
            context.Products.AddRange(product1);
            context.SaveChanges();
            var category1 = new List<Category>
            {
                new Category {  Name = "Electronics" },
                new Category {  Name = "Books" },
                new Category {  Name = "Clothing" },
                new Category {  Name = "Home & Kitchen" },
                new Category {  Name = "Accessories" }
            };
            context.Categories.AddRange(category1);
            context.SaveChanges();


        }
    }
}
