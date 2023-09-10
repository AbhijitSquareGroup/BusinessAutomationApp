using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Repositories.Abstractions.Products;
using BusinessAutomation.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repository
{
    public class ProductsRepository : BaseRepository<Product>,IProductRepository
    {
        BusinessAutomationDbContext db;
        public Guid Guid { get; set; }
        public ProductsRepository(BusinessAutomationDbContext db)
        {
            Guid = Guid.NewGuid();
            Debug.WriteLine("Product Repository is Created with : "+Guid.ToString());
            this.db = db;
            _db = db;
        }

        //public bool Add(List<Product>products)
        //{
        //    db.Products.AddRange(products);
        //    return db.SaveChanges() > 0;

        //}
        //public bool Update(Product product)
        //{
        //    db.Products.Update(product);
        //    return db.SaveChanges() > 0;
        //}
        //public bool Remove(Product product)
        //{
        //    product.IsDeleted = true;
        //    return Update(product);
        //}
        //public ICollection<Product> GetAll()
        //{
        //    return db.Products.ToList();
        //}




        public Product GetById(int id)
        {
            var existingProduct = db.Products.FirstOrDefault(p => p.Id == id);
            return existingProduct;
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




        public Brand FirstOrDefault()
        {
            throw new NotImplementedException();
        }
        public ICollection<Product> SearchProduct(ProductSearchCriteria searchCriteria)
        {
            var searchKey = searchCriteria.SearchKey;
            //string searchKey = "";
            var products = db.Products
                             .Include(c => c.Brand).AsQueryable();

            if (!string.IsNullOrEmpty(searchKey))
            {
                products = db.Products
                    .Where(c => c.Name.ToLower().Contains(searchKey.ToLower())
                        || c.Description.ToLower().Contains(searchKey.ToLower())
                    || (c.Brand == null ? false : c.Brand.Name.ToLower().Contains(searchKey.ToLower()))
                    );
            }
            if (searchCriteria.FromPrice != null)
            {
                products = products.Where(c => c.SalesPrice > searchCriteria.FromPrice);
            }
            if (searchCriteria.ToPrice != null)
            {
                products = products.Where(c => c.SalesPrice <= searchCriteria.ToPrice);
            }
            return products.ToList();

        }
    }
}
