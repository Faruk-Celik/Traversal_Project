using AutoMapper;
using BussinessLayer.Abstract;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.Controllers
{
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
        public IActionResult Index(SendMessageDTO sendMessageDTO)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContacUs()
                {
                    MessageBody = sendMessageDTO.MessageBody,
                    Mail = sendMessageDTO.Mail,
                    Name = sendMessageDTO.Name,
                    Subject = sendMessageDTO.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToLongDateString()),
                    IsDeleted = sendMessageDTO.IsDeleted
                }); 
                return RedirectToAction("Index","Default");
            }
            return View(sendMessageDTO);
        }
    }
}
