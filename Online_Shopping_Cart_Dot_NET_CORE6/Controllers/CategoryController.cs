using Microsoft.AspNetCore.Mvc;
using Online_Shopping_Cart_Dot_NET_CORE6.Infrasturecture;
using Online_Shopping_Cart_Dot_NET_CORE6.Models;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepo repo;

        public CategoryController(ICategoryRepo _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            var getcat = repo.GetCategories();
            return View(getcat);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category model)
        {
            var save = repo.Create(model);
            return View(save);   
        }
        public IActionResult Delete(int id)
        {
            var remove = repo.Delete(id);
            return RedirectToAction("Index");
            return View(remove);
        }


    }
}
