using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string purchaseDate { get; set; }
        public int status { get; set; }
    }
}
