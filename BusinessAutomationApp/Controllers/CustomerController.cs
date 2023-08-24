using BusinessAutomationApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusinessAutomationApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
         {
            return View();
        }
        public IActionResult Create(CustomerCreate customer) 
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
    }
}
