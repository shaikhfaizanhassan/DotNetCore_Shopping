using Online_Shopping_Cart_Dot_NET_CORE6.Data;
using Online_Shopping_Cart_Dot_NET_CORE6.Infrasturecture;
using Online_Shopping_Cart_Dot_NET_CORE6.Models;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Repository
{
    public class CategoryRepository : ICategoryRepo
    {
        private readonly Shopping_Db_Context db;

        public CategoryRepository(Shopping_Db_Context db)
        {
            this.db = db;
        }
        Category ICategoryRepo.Create(Category model)
        {
            var data = new Category()
            {
                Cat_Name = model.Cat_Name
            };
            db.categories.Add(data);
            db.SaveChanges();
            return data;
        }

        Category ICategoryRepo.Delete(int id)
        {
            var delete = db.categories.Find(id);
            if(delete!=null)
            {
                db.categories.Remove(delete);
                db.SaveChanges();
            }
            return delete;
        }

        List<Category> ICategoryRepo.GetCategories()
        {
            var getcat = db.categories.ToList();
            return getcat;
        }
    }
}
