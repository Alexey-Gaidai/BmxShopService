using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BmxShopService.Models
{
    public class Deliveries
    {
        public int id { get; set; }
        public int productsId { get; set; }
        [JsonIgnore]
        public Products products { get; set; }  
        public int deliveryDate { get; set; }
        public int productCount { get; set; }
    }
}
