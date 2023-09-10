using BusinessAutomation.Repository;
using System.Diagnostics;

namespace BusinessAutomationApp.DI_Test_Models
{
    public class RandomClass
    {
        ProductsRepository _productsRepository;
        public RandomClass(ProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
            Debug.WriteLine("Product Repo Guid in Random Class: "+productsRepository.Guid.ToString());
        }
    }
}
