namespace BmxShopService.Models.Client
{
    public class ProductClient
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string imageLink { get; set; }
        public float productPrice { get; set; }
        public int ManufacturerId { get; set; }
        public int categoryId { get; set; }
    }
}
