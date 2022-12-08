namespace BmxShopService.Models.Client
{
    public class Supplies
    {
        public int id { get; set; }
        public int productsId { get; set; }
        public string deliveryDate { get; set; }
        public int productCount { get; set; }
    }
}
