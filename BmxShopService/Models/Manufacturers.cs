using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BmxShopService.Models
{
    public class Manufacturers
    {
        public int id { get; set; }
        public string manufacturerName { get; set; }
        [JsonIgnore]
        public ICollection<Products> products { get; set; }
    }
}
