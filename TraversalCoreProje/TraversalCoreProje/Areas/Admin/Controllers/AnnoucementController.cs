using AutoMapper;
using Business.Abstract;
using DTO.DTOs.AnnoucementDTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
   [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AnnoucementController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAnnoucementService _annoucementService;

        public AnnoucementController(IMapper mapper, IAnnoucementService annoucementService)
        {
            _mapper = mapper;
            _annoucementService = annoucementService;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnoucementListDTO>>(_annoucementService.GetAll());
            return View(values);
        }
        public IActionResult DeleteAnnoucement(int id) {

            var values = _annoucementService.GetById(id);
            _annoucementService.Delete(values);
            return RedirectToAction("Index", "Annoucement", new { area = "Admin" });
        }
        [HttpGet]
        public IActionResult AddAnnoucement() { return View(); }
        [HttpPost]
        public IActionResult AddAnnoucement(AnnoucementAddDTOs model) {
            if (ModelState.IsValid) {
                _annoucementService.Insert(new Entity.Annoucement() { Title=model.Title,
                Content=model.Content,
                Date=Convert.ToDateTime(DateTime.Now.ToShortDateString())});
                return RedirectToAction("Index", "Annoucement", new { area = "Admin" });
            }
            return View(model); 
        }




        [HttpGet]
        public IActionResult UpdateAnnoucement(int id) {
            
            var values=_mapper.Map< AnnoucementUpdateDto>(_annoucementService.GetById(id));
            
            return View(values); }
        [HttpPost]
        public IActionResult UPdateAnnoucement(AnnoucementUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _annoucementService.Update(new Entity.Annoucement()
                {
                    Title = model.Title,
                    Content = model.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index", "Annoucement", new { area = "Admin" });
            }
            return View(model);
        }




    }
}
