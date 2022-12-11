using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BmxShopService.Models
{
    public class Orders
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int id { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public string purchaseDate { get; set; }
        public int status { get; set; }
        [JsonIgnore]
        public ICollection<OrderItems> orderItems { get; set; }
    }
}
