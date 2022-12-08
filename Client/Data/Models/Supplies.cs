using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data.Models
{
    public class Supplies
    {
        public int id { get; set; }
        public int productsId { get; set; }
        public string deliveryDate { get; set; }
        public int productCount { get; set; }
    }
}
