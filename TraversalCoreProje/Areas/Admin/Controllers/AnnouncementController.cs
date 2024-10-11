using AutoMapper;
using BussinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]

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
            var values = _mapper.Map<List<AnnouncementListDto>>(_announcementService.TGetList());
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
                _announcementService.TAdd(new Announcement()
                {
                    Content = addAnnouncementDto.Content,
                    Title = addAnnouncementDto.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");


            }
            return View(addAnnouncementDto);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            _announcementService.TDelete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<UpdateAnnouncementDto>(_announcementService.TGetById(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(UpdateAnnouncementDto dto)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    Id = dto.Id,
                    Content = dto.Content,
                    Title = dto.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())



                });
                return RedirectToAction("Index");


            }
            return View(dto);
        }
    }
}
