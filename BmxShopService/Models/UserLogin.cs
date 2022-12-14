using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BmxShopService.Models
{
    public class UserLogin
    {
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Role { get; set; }
        public User User { get; set; }
    }
}
