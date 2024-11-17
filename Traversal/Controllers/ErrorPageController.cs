using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Erorr404(int code)
        {
            return View();
        }
    }
}
