using System.ComponentModel.DataAnnotations;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }

        public UserTb UserTb { get; set; }
        public Product Product { get; set; }
    }
}
