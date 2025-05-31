using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()

        {
            return PartialView();
        }

        public PartialViewResult PartialSidebarTopMenu()

        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()

        {
            return PartialView();
        }

        public PartialViewResult PartialScript()

        {
            return PartialView();
        } 
    }
}
