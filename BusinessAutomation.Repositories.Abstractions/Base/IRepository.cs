using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Services.Abstraction.Base
{
    public interface IRepository<T> where T : class
    {
        ICollection<T> GetAll();
        bool Add(List<T> products);
        bool Update(T product);
        bool Remove(T product);
        //public T GetById(int id);
        //public ICollection<Product> SearchProduct(ProductSearchCriteria searchCriteria);

    }
}
