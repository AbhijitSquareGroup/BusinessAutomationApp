using System.ComponentModel.DataAnnotations;

namespace BusinessAutomation.Models
{
    public class CustomerCreate
    {
        //public CustomerCreate()
        //{
        //    new CustomerCreate();
        //}
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        //? dile nullable  not required
        public string? Email { get; set; }
    }
}
