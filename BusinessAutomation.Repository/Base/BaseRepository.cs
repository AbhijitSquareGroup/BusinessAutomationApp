using BusinessAutomation.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repository.Base
{
    public abstract class BaseRepository<T> where T : class
         
    {
        protected DbContext _db;
        /*public BaseRepository(DbContext db)
        {
            _db = db;
        }*/
        private DbSet<T> Table
        {
            get
            {
                return _db.Set<T>();
            }
        }
        public virtual ICollection<T> GetAll()
        {
            return Table.ToList();
        }

        public virtual bool Add(List<T> entity)
        {
            Table.AddRange(entity);
            return _db.SaveChanges() > 0;

        }

        /*public T GetById(int id)
        {
            var existingProduct = Table.FirstOrDefault();
            return existingProduct;
        }*/

        public virtual bool Update(T entity) 
        {
            Table.Update(entity);
            return _db.SaveChanges() > 0;
        }
        
        public virtual bool Remove(T entity)
        {
            Table.Remove(entity);
            return (_db.SaveChanges() > 0);
            //product.IsDeleted = true;
            //return Update(product);
        }
    }
}
