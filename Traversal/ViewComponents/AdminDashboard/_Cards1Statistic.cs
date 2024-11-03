using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Traversal.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.tursayisi = context.Destinations.Count();
            ViewBag.misafirsayisi = context.Users.Count();
            return View();
        }
    }
}
