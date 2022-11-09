using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmxShopClient.Data.Models
{
    public class AuthInfo
    {
        public string access_token { get; set; }
        public string username { get; set; }
        public string role { get; set; }
    }
}
