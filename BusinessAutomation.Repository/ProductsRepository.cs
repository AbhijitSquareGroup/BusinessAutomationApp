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

        public bool Add(List<Product>products)
        {
            db.Products.AddRange(products);
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
        //SOFT delete......................when fk and pk relation in others tabels
        public bool Remove(Product product)
        {
            product.IsDeleted = true;
            return Update(product);
        }

        public Brand FirstOrDefault()
        {
            throw new NotImplementedException();
        }
    }
}
