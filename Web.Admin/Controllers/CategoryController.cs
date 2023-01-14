using Microsoft.AspNetCore.Mvc;

namespace Web.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
