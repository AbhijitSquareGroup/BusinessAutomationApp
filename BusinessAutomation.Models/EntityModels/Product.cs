using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessAutomation.Models.EntityModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
      
        //public string Category { get; set; }
        public double SalesPrice { get; set; }
        /*public int BrandId { get; set; }*/
        //public string ProductCategory { get; set; }
        public  Brand Brand { get; set; }
        [ForeignKey("Brand")]

        public int? BrandId { get; set; }
        public bool IsDeleted { get; set; }

        public string GetInfo()
        {
            var message = $"Name:{Name} Desc:{Description} SalesPrice:{SalesPrice}";
            if(Brand != null)
            {
                message += $"  Brand : {Brand.Name}";
            }
            return message ; 
        }
    }
}
