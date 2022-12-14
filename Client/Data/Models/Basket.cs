using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data.Models
{
    public class Basket
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public float productPrice { get; set; }
        public int count { get; set; }
    }
}
