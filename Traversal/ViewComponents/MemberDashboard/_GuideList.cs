﻿using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EFGuideDal());

        public IViewComponentResult Invoke()
        {
            var values = guideManager.TGetList(); 
            return View(values);
        }
    }
}
