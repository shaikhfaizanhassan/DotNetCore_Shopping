using Online_Shopping_Cart_Dot_NET_CORE6.Data;
using Online_Shopping_Cart_Dot_NET_CORE6.Infrasturecture;
using Online_Shopping_Cart_Dot_NET_CORE6.Models;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Repository
{
    public class BrandRepository : IBrandRepo
    {
        private readonly Shopping_Db_Context db;

        public BrandRepository(Shopping_Db_Context db)
        {
            this.db = db;
        }
        Brand IBrandRepo.Create(Brand model)
        {
            var data = new Brand()
            {
                Brand_Name = model.Brand_Name,
            };
            db.brands.Add(data);
            db.SaveChanges();
            return data;
        }

        Brand IBrandRepo.Delete(int id)
        {
            var delete = db.brands.Find(id);
            if (delete != null)
            {
                db.brands.Remove(delete);
                db.SaveChanges();
            }
            return delete;
        }

        List<Brand> IBrandRepo.Getbrand()
        {
            var getbrand = db.brands.ToList();
            return getbrand;
        }
    }
}
