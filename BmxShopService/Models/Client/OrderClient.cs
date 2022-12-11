namespace BmxShopService.Models.Client
{
    public class OrderClient
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string purchaseDate { get; set; }
        public int status { get; set; }
    }
}
