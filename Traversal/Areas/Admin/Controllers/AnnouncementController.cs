using AutoMapper;
using BusinnesLayer.Abtstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Traversal.Areas.Admin.Models;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<ListAnnouncementDto>>(_announcementService.TGetList());  
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AddAnnouncementDto addAnnouncementDto)
        {
            if (ModelState.IsValid)
            {
                addAnnouncementDto.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                var addAnnouncement = _mapper.Map<Announcement>(addAnnouncementDto);
                _announcementService.TAdd(addAnnouncement);
                return RedirectToAction("Index", "Announcement", new { areas = "Admin" });
            }
            return View(addAnnouncementDto);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.TGetByID(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<UpdateAnnouncementDto>(_announcementService.TGetByID(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(UpdateAnnouncementDto updateAnnouncementDto)
        {
            if (ModelState.IsValid)
            {
                updateAnnouncementDto.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                var result = _mapper.Map<Announcement>(updateAnnouncementDto);
                _announcementService.TUpdate(result);
                return RedirectToAction("Index");
            }
            return View(updateAnnouncementDto);
        }
    }
}
