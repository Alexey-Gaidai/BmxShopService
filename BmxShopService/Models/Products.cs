using Microsoft.Extensions.ObjectPool;
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
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int ManufacturerId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int categoryId { get; set; }
        public Manufacturers manufacturer { get; set; }
        public Categories category { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<Deliveries> deliveries { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<OrderItems> orderItems { get; set; }
    }
}
