using Fruit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fruit.ViewModels;
using AutoMapper;
using System.Data.Entity;


namespace Fruit.Areas.Admin.Controllers
{
    public class DrinkController : Controller
    {
        private ApplicationDbContext _context;

        public DrinkController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Admin/Drink
        public ActionResult Index()
        {
            var informationInDb = _context.Information.ToList();
            var containerInDb = _context.Container.ToList();

            var informationListViewModel = new List<InformationViewModel>();
            var containerListViewModel = new List<ContainerViewModel>();

            Mapper.Map(informationInDb, informationListViewModel);
            Mapper.Map(containerInDb, containerListViewModel);

            //var commonViewModel = new CommonViewModel
            //{
            //    InformationViewModel = informationListViewModel,
            //    ContainerViewModel = containerListViewModel
            //};

            

            return View(commonViewModel);
        }

        [HttpPost]
        public ActionResult UpdateInformation(CommonViewModel model)
        {
            var information = _context.Information.ToList();

            Mapper.Map(model, information);

            _context.SaveChanges();

            return RedirectToAction("Index", "Drink");
        }
    }
}