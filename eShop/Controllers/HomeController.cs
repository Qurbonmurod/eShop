using eShop.Data;
using eShop.Data.Interfaces;
using eShop.Domain;
using eShop.Models;
using eShop.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly ITVRepository _tv;
        private readonly ITVRepository _tvRepository;

        //public HomeController(ITVRepository tvrepository)
        //{
        //    _tvRepository = tvrepository;
        //}
        public HomeController(ILogger<HomeController> logger,ITVRepository tVRepository)
        {
            _logger = logger;
            _tvRepository = tVRepository;

        }

        public IActionResult Index()
        {
           // var model = _tvRepository.GetAll();
            HomeIndexViewModel viewModel1= new HomeIndexViewModel()
            {
                TVs = _tvRepository.GetAll()
            };
            return View(viewModel1);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult Index1()
        {
            return Json(new { id = "1", lastname = "Anvar", surname = "Xayrullayev" });
        }
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel viewModel = new HomeDetailsViewModel
            {
                TV = _tvRepository.getbyid(id??1),
            Title = "TV Details"
        };
                return View(viewModel);
        }
        [HttpGet]
        public  ViewResult Creat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Creat(TV tv)
        {
           var newTV= _tvRepository.Creat(tv);
           return  RedirectToAction("details", new { id = newTV.Id });
            
        }
        [HttpGet]
        public ViewResult Update(int id)
        {
            var existingTV = _tvRepository.getbyid(id);

            TV newTv = new TV
            {
                Id = existingTV.Id,
                Name = existingTV.Name,
                Short = existingTV.Short,
                Long = existingTV.Long,
                Price = existingTV.Price
            };

            return View(newTv);
        }
        [HttpPost]
        public IActionResult Update(TV updateTV)
        {
            var newTV = _tvRepository.Update(updateTV );
            return RedirectToAction("index");

        }

    }
}
