using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Services.Abstraction.Products
{
    public interface IProductService
    {
        ICollection<Product> GetAll();
        bool Add(List<Product> products);
        bool Update(Product product);
        bool Remove(Product product);
        public Product GetById(int id);
        public ICollection<Product> SearchProduct(ProductSearchCriteria searchCriteria);

    }
}
