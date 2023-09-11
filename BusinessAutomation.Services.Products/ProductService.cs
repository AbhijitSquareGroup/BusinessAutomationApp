using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Repositories.Abstractions.Products;
using BusinessAutomation.Services.Abstraction.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Services.Products
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        public ProductService()
        {
            _productRepository
        }
        public bool Add(List<Product> products)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Product product)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> SearchProduct(ProductSearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
