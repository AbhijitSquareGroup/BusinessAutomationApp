using BusinessAutomationApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusinessAutomationApp.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerController()
        {
            CustomerTable  = new List<CustomerCreate>();
        }
        public IActionResult Index()
         {
            return View();
        }
        //First timeget request kori
        [HttpPost]
        public IActionResult Create(CustomerCreate customer) 
        {
            if(ModelState.IsValid) 
            {
                if(customer.Phone.Length == 11) 
                {
                    CustomerTable.Add(customer);
                }
                else
                {
                    ModelState.AddModelError("Phone","Phone must be 11 digit");
                }
            }
           
            //if(customer.Name!=null && customer.Email!=null)
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        { 
            return View(); 
        }
       /* public string Create(CustomerCreate customer)
        {
            return $"this is the create page: {customer.Name} phone :{customer.Phone}";
        }*/
        public string CreateList(CustomerCreate[] customer) 
        {
            string message = "";
            foreach(var c in customer) 
            {
                message += $"this is the create page: {c.Name} phone :{c.Phone}\n";
            }
            return message ;    
        }
        public static List<CustomerCreate> CustomerTable;
    }
}
