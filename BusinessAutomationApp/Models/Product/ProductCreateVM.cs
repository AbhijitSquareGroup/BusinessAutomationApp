using BusinessAutomation.Models.EntityModels;
using System.Text;

namespace BusinessAutomationApp.Models.Product
{
    public class ProductCreateVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double SalesPrice { get; set; }
        public int BrandId { get; set; }
        public ICollection<Brand>? Brands { get; set; }
    }
}
