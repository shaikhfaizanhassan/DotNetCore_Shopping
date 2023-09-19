using System.ComponentModel.DataAnnotations;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Models
{
    public class Shippment
    {
        [Key]
        public int ShipmentId { get; set; }
        public int OrderId { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string ShipmentStatus { get; set; }
        public Orders Orders { get; set;}
    }
}
