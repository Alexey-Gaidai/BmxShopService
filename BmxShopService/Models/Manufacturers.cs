using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BmxShopService.Models
{
    public class Manufacturers
    {
        public int Id { get; set; }
        public string manufacturerName { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<Products> products { get; set; }
    }
}
