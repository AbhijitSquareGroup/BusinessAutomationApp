using BusinessAutomation.Database;
using BusinessAutomation.Models;
using BusinessAutomation.Models.Customer;
using BusinessAutomation.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;


namespace BusinessAutomation.Controllers
{
    public class CustomerController : Controller
    {
        BusinessAutomationDbContext db;
        public CustomerController()
        {
            CustomerTable  = new List<CustomerCreate>();
            db = new BusinessAutomationDbContext(); 
        }
        public IActionResult Index()
         {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        //First timeget request kori
        [HttpPost]
        public IActionResult Create(CustomerCreate customer) 
        {
            if (customer.Phone.Length != 11)
            {
                ModelState.AddModelError("Phone", "Phone must be 11 digit");
            }

            if (ModelState.IsValid)
            {
                //data save operation
                var entity = new Customer()
                {
                    Name = customer.Name,
                    Email= customer.Email,
                    Phone = customer.Phone,

                };
                db.Customers.Add(entity);
                int successCount=db.SaveChanges();
                if(successCount > 0)
                {
                    ViewBag.SuccessMessage = "Saved SuccessFully";
                    return View("Success");
                }

                //CustomerTable.Add(customer);
                ViewBag.SuccessMessage = "Save Successfully";
                return View("Success");  
            } 
            
           
            //if(customer.Name!=null && customer.Email!=null)
            return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            var customerList = new List<CustomerCreate>() 
            {
                new CustomerCreate()
            {
                Name = "Abhijit",
                Phone = "01862285708",
                Email = "a@gmail.com"
            }
        };
            var Company = new Company()
            {
                CompanyId = "C001",
                Name = "ABC",
                Location = "Mohakhali"
            };
            var customerListVM = new CustomerList()
            {
                Company = Company,
                Customers = customerList,
            };

            //ViewBag.CustomerList = customerList;
           // return View("SuccessList", customerList);   
            return View(customerListVM);
        }
        
        /* public string Create(CustomerCreate customer)
         {
             return $"this is the create page: {customer.Name} phone :{customer.Phone}";
         }*/
        public string CreateList(CustomerCreate[] customer)
        {
            string message = "";
            foreach (var c in customer)
            {
                message += $"this is the create page: {c.Name} phone :{c.Phone}\n";
            }
            return message;
        }
        public static List<CustomerCreate> CustomerTable;
    }
}
