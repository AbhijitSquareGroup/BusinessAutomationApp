using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repository;
using Microsoft.EntityFrameworkCore;

namespace BusinessAutomation.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Product
            /* List<Product> products = new List<Product>()
             {
                 new Product()
             {
                 Name = "Kelvinator AC",
                 Description = "AC",
                 *//*Brand = "Sony",*//*
                 SalesPrice = 90000.0
             },
              new Product()
             {
                 Name = "Iphone 14 Pro Max",
                 Description = "Phone",
                *//* Brand = "Apple",*//*
                 SalesPrice = 160000.0
             },
         };*/
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

            //Create New brand ----------------------


            /*Brand brand = new Brand()
            {
                Name = "Huwai",
        //    };*/
        //    BusinessAutomationDbContext db = new BusinessAutomationDbContext();
        //    //ProductsRepository productsRepository1 = new ProductsRepository();
        //    var existingBrand = db.Brands.FirstOrDefault(x => x.Id == 3);
        //    if (existingBrand == null)
        //    {
        //        throw new Exception("Brand not Found");
        //    }

        //    List<Product> products = new List<Product>()
        //    {
        //        new Product()
        //    {
        //        Name = "Huwai P987",
        //        Description = "Phone",
        //        SalesPrice = 150000.0,
        //        Brand = existingBrand,
        //    },
        //    /*    new Product()
        //    {
        //        Name = "Iphone 15 pro max",
        //        Description = "Phone",
        //        BrandId = 2,
        //        SalesPrice = 130000.0
        //    },new Product()
        //    {
        //        Name = "Kelvinator Microwave",
        //        Description = "Ac",
        //        BrandId = 1,
        //        SalesPrice = 30000.0
        //    }*/
        //};
            /* db.Products.AddRange(products);
             bool isSuccess = db.SaveChanges()>0;*/
            /*var product1 = new Product()
            {
                Name = "Kelvinator AC",
                Description = "AC",
                BrandId = 1,
                SalesPrice = 90000.0
            };
            var product2=new Product()
            {
                Name = "Iphone 15 pro max",
                Description = "Phone",
                BrandId = 2,
                SalesPrice = 130000.0
            };
            var product3=new Product()
            {
                Name = "Kelvinator Microwave",
                Description = "Ac",
                BrandId = 1,
                SalesPrice = 30000.0
            };*/
            //bool isS
            //db.Products.Add(product1);
            //db.Products.Add(product2);
            //db.AddRange(products);
            //ProductsRepository productsRepository = new ProductsRepository();
            //bool isSuccess=productsRepository.Add(products);






            //UPDATE OPERATION........
            /*
                        var existingProduct = productsRepository.GetById(4);
                        existingProduct.Name = "Iphone 11 pro [updated]";
                        existingProduct.Description = "Phone [Updated]";
                        existingProduct.SalesPrice = 110000;
                        bool isSuccess = productsRepository.Update(existingProduct);
            */

            //DELETE METHOD

            //productsRepository.Delete(6);




            //var existingProduct =db.Products.FirstOrDefault(p=> p.Id == 3);

            //db.Update(existingProduct);
            //int successCount=db.SaveChanges(isSuccess);
            /* if (isSuccess)
             {
                 Console.WriteLine("Saved Successfully");
             }*/
















            //CRUD---------------------Session Related data Part-01

            BusinessAutomationDbContext db = new BusinessAutomationDbContext();
            //prottekta alada accosiacet object
            //er jonno include diye alada alada likhte hobe
            //EGER LOADING
            //LINQ->Collection e kaj kore
            //LAMDA EXPRESSION APPROACH>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            var products = db.Products.Where(p=> p.SalesPrice > 50000 && p.SalesPrice < 100000);
                             //.Include(c => c.Brand)
                             //.AsQueryable();
            //CLASIC APPROACH>>>>>>>>>>>>>>>>>>>
           /* var existingProducts =from p in db.Products
                                  where p.SalesPrice >50000 && p.SalesPrice <100000
                                  orderby p.Id
                                  select p;*/
            foreach (var product in products)
            {
                Console.WriteLine(product.GetInfo());
            }










        }
    }
}