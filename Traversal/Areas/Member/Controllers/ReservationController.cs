﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        public IActionResult MyCurrentReservation()
        {
            return View();
        }

        public IActionResult OldReservation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservetion p)
        {
            return View();
        }
    }
}
