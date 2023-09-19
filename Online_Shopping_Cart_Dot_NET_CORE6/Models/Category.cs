using System.ComponentModel.DataAnnotations;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Models
{
    public class Category
    {
        [Key]
        public int Cat_ID { get; set; }
        public string Cat_Name { get; set; }
    }
}
