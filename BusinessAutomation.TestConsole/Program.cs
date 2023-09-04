using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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

            //Customer ________________CRUD from BasrRepository
            List<Customer> customerList = new List<Customer>()
            {
                 new Customer()
            {
                Name = "Test",
                Email ="a@gmail.com",
                //Id = 10,
                //Address="BANANI",
                Phone ="87894556"
             }
            };

            CustomerRepository customerRepository = new CustomerRepository();
            bool isAdded = customerRepository.Add(customerList);
            if (isAdded)
            {
                Console.WriteLine("Customer Added");
            }
            //List<Customer> customerList














            //CRUD---------------------Session Related data Part-01

            //BusinessAutomationDbContext db = new BusinessAutomationDbContext();
            //ProductsRepository productsRepository= new ProductsRepository();    

            //Console.WriteLine("Provide searchKey...........");
            //string searchKey= Console.ReadLine();
            //double? fromPrice=null;
            //double? toPrice=90000;
            //var searchCriteria = new ProductSearchCriteria()
            //{
            //    SearchKey =searchKey ,
            //    FromPrice =fromPrice ,
            //    ToPrice =toPrice    
            //};
            //var products = productsRepository.SearchProduct(searchCriteria); 
















            //Deferd Execution,,,,,,,,,,,,,,,,,,,,AsQueryable
            /*string searchKey = "";
            var products = db.Products
                             .Include(c=>c.Brand).AsQueryable();
            if (string.IsNullOrEmpty(searchKey))
            {
                products = db.Products.Where(c=>c.Name.ToLower().Contains(searchKey.ToLower())
                ||c.Description.ToLower().Contains(searchKey.ToLower())
                ||(c.Brand==null?false: c.Brand.Name.ToLower().Contains(searchKey.ToLower()))
                
                );
            }
*/
            //prottekta alada accosiacet object
            //er jonno include diye alada alada lifkhte hobe






            //EGER LOADING
            //LINQ->Collection e kaj kore
            //LAMDA EXPRESSION APPROACH>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            //Filter Include in eger Loading/..........................
            //var brands = db.Brands
            //               .Include(b => b.products.Where(p => p.SalesPrice > 50000 && p.SalesPrice < 100000));


            //var products = db.Products
            //                 .Where(p => p.SalesPrice > 50000 && p.SalesPrice < 100000);
            //.Select(p=> new { p.Name, p.Description, p.SalesPrice });
            //.Include(c => c.Brand)
            //.AsQueryable();





            //CLASIC APPROACH>>>>>>>>>>>>>>>>>>>
            //var existingProducts = from p in db.Products
            //                       where p.SalesPrice > 50000 && p.SalesPrice < 100000
            //                       select new { p.Name,p.Description,p.SalesPrice };
            //                       //orderby p.Id
            //                       //select p;





            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.GetInfo());
            //}










        }
    }
}