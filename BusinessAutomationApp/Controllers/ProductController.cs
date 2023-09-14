using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Repositories.Abstractions.Products;
using BusinessAutomation.Repository;
using BusinessAutomation.Services.Abstraction.Products;
using BusinessAutomationApp.DI_Test_Models;
using BusinessAutomationApp.Models.Product;
using Microsoft.AspNetCore.Mvc;


namespace BusinessAutomationApp.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        BrandRepository _brandRepository;
        //Dependency Injecection ADScopped ,AddTransient.....
        //RandomClass _randomClass;
        //public ProductController()
        //{
        //    _productService = new ProductsRepository();
        //    _brandRepository = new BrandRepository();
        //}

        public ProductController(IProductService productService, BrandRepository brandsRepository)
        {
            _productService = productService;
            _brandRepository = brandsRepository;
            //_randomClass = randomClass;
        }
        public IActionResult Index(ProductIndex model)
        {
            ICollection<Product> products = new List<Product>();
            if (model.SearchKey != null)
            {
                var ProductSearchCriteria = new ProductSearchCriteria()
                {
                    SearchKey = model.SearchKey,
                    /*FromPrice = model.FromPrice,
                    ToPrice = model.ToPrice*/
                };
                products = _productService.SearchProduct(ProductSearchCriteria);
            }
            else
            {
                products = _productService.GetAll();
            }



            // Use LINQ to project products into ProductListItem
            var productList = products.Select(product => new ProductListItem
            {
                Id= product.Id,
                Name = product.Name,
                Description = product.Description,
                SalesPrice = product.SalesPrice
            }).ToList();

            model.ProductList = productList;

            //AutoMapper

            return View(model);
        }
        public IActionResult Create()
        {
            ProductCreateVM model = new ProductCreateVM()
            {
                Brands = _brandRepository.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(ProductCreateVM model)
        {
            if (ModelState.IsValid)
            {
                List<Product> products = new List<Product>()
                {
                    new Product()
                {
                    Name = model.Name,
                    Description = model.Description,
                    SalesPrice = model.SalesPrice,
                    BrandId =model.BrandId
                },
                };
                bool isSuccess = _productService.Add(products);
                if (isSuccess)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(model);

        }
        //product/edit?id=8
        public IActionResult Edit(int? id)
        {
            if(id== null)
            {
                ViewBag.ErrorMessage = "Id is not set for the Products!";
                return View("_ApplicationError");
            }
            var existingProduct = _productService.GetById((int)id);
            if(existingProduct == null) 
            {
                ViewBag.ErrorMessage = $"Did not Find Any Product with id : {id}";
                return View("_ApplicationError");
            }
            var productEditVM =new ProductEditVM()
            {
                Id=existingProduct.Id,
                Name=existingProduct.Name,
                Description=existingProduct.Description,
                SalesPrice=existingProduct.SalesPrice,
            }; 
            return View(productEditVM);
        }

        [HttpPost]
        public IActionResult Edit(ProductEditVM model)
        {
            if (ModelState.IsValid)
            {
                var productToUpdate = _productService.GetById(model.Id);
                productToUpdate.Description = model.Description;
                productToUpdate.Name = model.Name;
                productToUpdate.SalesPrice = model.SalesPrice;
                bool isSuccess = _productService.Update(productToUpdate);
                if (isSuccess)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(model);

        }
        public IActionResult Remove(int? id)
        {
            if (id == null)
            {
                ViewBag.ErrorMessage = "Id is not set for the Products!";
                return View("_ApplicationError");
            }
            var existingProduct = _productService.GetById((int)id);
            if (existingProduct == null)
            {
                ViewBag.ErrorMessage = $"Did not Find Any Product with id : {id}";
                return View("_ApplicationError");
            }

            _productService.Remove(existingProduct);

            return RedirectToAction("Index");
        }
    }
}
