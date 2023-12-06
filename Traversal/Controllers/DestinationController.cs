using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
