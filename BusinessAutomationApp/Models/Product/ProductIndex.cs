namespace BusinessAutomationApp.Models.Product
{
    public class ProductIndex
    {
        public string SearchKey { get; set; }
        /*public double  FromPrice { get; set; }

        public double ToPrice { get; set; }*/
        public ICollection<ProductListItem> ProductList { get; set; }
    }
}
