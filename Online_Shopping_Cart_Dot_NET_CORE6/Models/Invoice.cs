using System.ComponentModel.DataAnnotations;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        public Orders Orders { get; set;}
    }
}
