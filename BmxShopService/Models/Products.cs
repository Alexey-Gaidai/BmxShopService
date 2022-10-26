using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BmxShopService.Models
{
    public class Products
    {
        public int id { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public float productPrice { get; set; }
        public int manufacturerId { get; set; }
        [NotMapped]
        public Manufacturers manufacturer { get; set; }
        public int categoryId { get; set; }
        [NotMapped]
        public Categories category { get; set; }
        [NotMapped]
        public ICollection<Deliveries> deliveries { get; set; }
        [NotMapped]
        public ICollection<OrderItems> orderItems { get; set; }
    }
}
