using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BmxShopService.Models
{
    public class Orders
    {
        public int id { get; set; }
        public string customerNumber { get; set; }
        public string customerAdress { get; set; }
        public int purchaseDate { get; set; }
        [JsonIgnore]
        public ICollection<OrderItems> orderItems { get; set; }
    }
}
