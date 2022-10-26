using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BmxShopService.Models
{
    public class Categories
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        [JsonIgnore]
        public ICollection<Products> products { get; set; }
    }
}
