using System.ComponentModel.DataAnnotations;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Models
{
    public class Admin
    {
        [Key]
        public int A_Id { get; set; }
        public string A_Email { get; set; }
        public string A_Password { get; set; }

    }
}
