using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repository
{
    public class BrandRepository
    {
        BusinessAutomationDbContext db;
        public BrandRepository()
        {
            db = new BusinessAutomationDbContext();
        }

        public bool Add(List<Brand> Brands)
        {
            db.Brands.AddRange(Brands);
            return db.SaveChanges() > 0;

        }

        public Brand GetById(int id)
        {
            var existingBrand = db.Brands.FirstOrDefault(p => p.Id == id);
            return existingBrand;
        }

        public bool Update(Brand Brand)
        {
            db.Brands.Update(Brand);
            return db.SaveChanges() > 0;
        }
        public void Delete(int BrandId)
        {
            var Brand = db.Brands.Find(BrandId);
            if (Brand != null)
            {
                db.Brands.Remove(Brand);
                db.SaveChanges();
                Console.WriteLine("Brand is Deleted");
            }
        }
        

        public Brand FirstOrDefault()
        {
            throw new NotImplementedException();
        }
    }
}
