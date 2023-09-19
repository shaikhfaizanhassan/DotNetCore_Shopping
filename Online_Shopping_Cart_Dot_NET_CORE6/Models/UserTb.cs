using System.ComponentModel.DataAnnotations;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Models
{
    public class UserTb
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public List<Orders> Orders { get; set; }
    }
}
