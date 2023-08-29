using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repository;

namespace BusinessAutomation.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Product
            List<Product> products = new List<Product>()
            {
                new Product()
            {
                Name = "Kelvinator AC",
                Description = "AC",
                Brand = "Sony",
                SalesPrice = 90000.0
            },
             new Product()
            {
                Name = "Iphone 14 Pro Max",
                Description = "Phone",
                Brand = "Apple",
                SalesPrice = 160000.0
            },
        };
            //var product1 = new Product()
            //{
            //    Name = "Sony Bravia",
            //    Description = "Tv",
            //    Brand = "Sony",
            //    SalesPrice = 82000.0
            //};
            //var product2 = new Product()
            //{
            //    Name = "Iphone 13 Pro Max",
            //    Description = "Phone",
            //    Brand = "Apple",
            //    SalesPrice = 130000.0
            //};
            // BusinessAutomationDbContext db = new BusinessAutomationDbContext();
            //db.Products.Add(product1);
            //db.Products.Add(product2);
            //db.AddRange(products);
            ProductsRepository productsRepository = new ProductsRepository();

            //UPDATE OPERATION........
            var existingProduct = productsRepository.GetById(4);
            existingProduct.Name = "Iphone 11 pro [updated]";
            existingProduct.Description = "Phone [Updated]";
            existingProduct.SalesPrice = 110000;
            bool isSuccess = productsRepository.Update(existingProduct);


            //DELETE METHOD

            productsRepository.Delete(5);
            



            //var existingProduct =db.Products.FirstOrDefault(p=> p.Id == 3);

            //db.Update(existingProduct);
            //int successCount=db.SaveChanges(isSuccess);
            if (isSuccess)
            {
                Console.WriteLine("Saved Successfully");
            }
        }
    }
}