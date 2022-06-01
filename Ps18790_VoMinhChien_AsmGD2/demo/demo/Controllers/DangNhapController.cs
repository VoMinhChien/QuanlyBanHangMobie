using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class DangNhapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
