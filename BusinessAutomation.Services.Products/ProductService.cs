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
        public ProductService(IProductRepository productRepository)
        {
            _productRepository= productRepository;  
        }
        public bool Add(List<Product> products)
        {
            bool isSuccess= _productRepository.Add(products);
            return isSuccess;
        }

        public ICollection<Product> GetAll()
        {
            //Logic
            var products = _productRepository.GetAll();
            return products;
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public bool Remove(Product product)
        {
            bool isSuccess= _productRepository.Remove(product);
            return isSuccess;
        }

        public ICollection<Product> SearchProduct(ProductSearchCriteria searchCriteria)
        {
            return _productRepository.SearchProduct(searchCriteria);
        }

        public bool Update(Product product)
        {
            bool isSuccess = _productRepository.Update(product);
            return isSuccess;   
        }
    }
}
