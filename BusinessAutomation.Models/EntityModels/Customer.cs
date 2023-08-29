using System.ComponentModel.DataAnnotations;

namespace BusinessAutomation.Models.EntityModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
        public string Phone { get; set; }
        //? dile nullable / not required
        public string? Email { get; set; }
        //public string CustomerType { get; set; }
    }
}
