using BusinnesLayer.Abtstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class _LastDestinations : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _LastDestinations(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = _destinationService.TGetLast4Destinations();
            return View(values);
        }
    }
}
