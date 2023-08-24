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
        public string Create(CustomerCreate customer)
        {
            return $"this is the create page: {customer.Name} phone :{customer.Phone}";
        }
    }
}
