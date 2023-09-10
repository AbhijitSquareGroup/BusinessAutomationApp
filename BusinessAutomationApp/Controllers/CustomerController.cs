using BusinessAutomation.Database;
using BusinessAutomation.Models;
using BusinessAutomation.Models.Customer;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repository;
using Microsoft.AspNetCore.Mvc;


namespace BusinessAutomation.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository _customerRepository;
        public CustomerController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository; 
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
                List<Customer> customers = new List<Customer>()
                {

               new Customer()

                {
                    Name = customer.Name,
                    Email= customer.Email,
                    Phone = customer.Phone,

                 }
                };
                var isSuccess = _customerRepository.Add(customers);
                if(isSuccess)
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
