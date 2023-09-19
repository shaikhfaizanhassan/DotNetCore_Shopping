using System.ComponentModel.DataAnnotations;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Models
{
    public class Product
    {
        [Key]
        public int ProId { get; set; }
        public string ProName { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public decimal ProPrice { get; set; }

        public Brand Brand { get; set; }
        public Category Category { get; set; }  
    }
}
