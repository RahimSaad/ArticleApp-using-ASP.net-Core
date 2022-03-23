using Microsoft.AspNetCore.Mvc;
using ArticlesApp.BL;
using ArticlesApp.Models;

namespace ArticlesApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            CLSArticle cls = new CLSArticle();
            return View(cls.GetAll());
        }

        public IActionResult addArticle()
        {
            return View();
        }

        public IActionResult save(Article art)
        {
            if (ModelState.IsValid)
            {
                CLSArticle cls = new CLSArticle();
                cls.Add(art);
                return Redirect("Index");
            }
            return View(art);
        }

    }
}
