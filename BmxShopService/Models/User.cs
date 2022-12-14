using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BmxShopService.Models
{
    public class User
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UserImage { get; set; } = "";
        public ICollection<Orders> Orders { get; set; }
        public UserLogin userLogin { get; set; }
    }
}
