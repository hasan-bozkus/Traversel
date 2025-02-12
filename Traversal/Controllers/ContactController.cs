using AutoMapper;
using BusinnesLayer.Abtstract;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageDto sendMessageDto)
        {
            if (ModelState.IsValid)
            {
                sendMessageDto.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                sendMessageDto.MessageStatus = true;
                var result = _mapper.Map<ContactUs>(sendMessageDto);
                _contactUsService.TAdd(result);
                return RedirectToAction("Index", "Default");
            }
            return View(sendMessageDto);
        }
    }
}
