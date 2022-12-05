using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data.Models
{
    public class OrderItems
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int productId { get; set; }
        public int Count { get; set; }
    }
}
