using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BmxShopService.Models
{
    public class OrderItems
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public Orders order { get; set; }
        public int productId { get; set; }
        [NotMapped]
        public Products product  { get; set; }
        public int productCount { get; set; }
    }
}
