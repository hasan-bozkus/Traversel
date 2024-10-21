using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using EntityLayer.Concrete;
using System.Threading.Tasks;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class _ProfileInformation : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userFullName = values.Name + " " + values.Surname;
            ViewBag.userPhoneNumber = values.PhoneNumber;
            ViewBag.userEmail = values.Email;
            return View();
        }
    }
}
