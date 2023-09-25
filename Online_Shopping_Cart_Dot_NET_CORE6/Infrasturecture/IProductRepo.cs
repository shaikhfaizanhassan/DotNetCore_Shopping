using Online_Shopping_Cart_Dot_NET_CORE6.Models;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Infrasturecture
{
    public interface IProductRepo
    {
        List<Product> GetAllProduct();
    }
}
