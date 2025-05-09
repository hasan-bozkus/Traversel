﻿using BusinnesLayer.Abtstract;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Destination
{
    public class _GuideDetails : ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideDetails(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetByID(1);
            return View(values);
        }
    }
}
