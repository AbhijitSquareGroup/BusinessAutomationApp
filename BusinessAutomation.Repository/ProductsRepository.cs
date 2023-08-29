using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repository
{
    public class ProductsRepository
    {
        BusinessAutomationDbContext db;
        public ProductsRepository()
        {
            db = new BusinessAutomationDbContext();
        }
        public bool Add(Product product)
        {
            db.Products.Add(product);
            return db.SaveChanges() > 0;

        }

        public Product GetById(int id)
        {
            var existingProduct = db.Products.FirstOrDefault(p => p.Id == id);
            return existingProduct;
        }

        public bool Update(Product product)
        {
            db.Products.Update(product);
            return db.SaveChanges() > 0;
        }
        public void Delete(int productId)
        {
            var product = db.Products.Find(productId);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                Console.WriteLine("Product is Deleted");
            }
        }
    }
}
