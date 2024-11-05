using BusinnesLayer.Abtstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;

        public UserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {
            var result = _appUserService.TGetByID(id);
            _appUserService.TDelete(result);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var result = _appUserService.TGetByID(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {
            _appUserService.TGetList();
            return View();
        }

        public IActionResult ReservationUser(int id)
        {
            _appUserService.TGetList();
            return View();
        }
    }
}
