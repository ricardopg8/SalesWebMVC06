using Microsoft.AspNetCore.Mvc;

namespace SalesWebMVC06.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
