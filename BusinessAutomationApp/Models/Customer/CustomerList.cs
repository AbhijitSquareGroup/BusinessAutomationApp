using System.Reflection;

namespace BusinessAutomation.Models.Customer
{
    public class CustomerList
    {
        public List<CustomerCreate> Customers { get; set; }
        public Company Company { get; set; }
    }
}
