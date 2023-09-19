using System.ComponentModel.DataAnnotations;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Models
{
    public class Brand
    {
        [Key]
        public int Brnd_Id { get; set; }
        public string Brand_Name { get; set; }

    }
}
