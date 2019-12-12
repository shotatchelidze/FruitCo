using Fruit.ViewModels;
using Fruit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using System.Data.Entity;

namespace Fruit.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    
        }

        public ActionResult Index()
        {
            //var informationInDb = _context.MainPage.ToList().Take(2);
            ////var informationInDb = _context.MainPage.Include(c => c.Images).ToList().Take(2);
            //var imageInDb = _context.ImagePath.ToList();

            //var informationListViewModel = new List<MainPageViewModel>();
            //var imageListViewModel = new List<ImageViewModel>();

            //Mapper.Map(informationInDb, informationListViewModel);
            //Mapper.Map(imageInDb, imageListViewModel);

            //var mainPageCommonViewModel = new MainPageCommonViewModel()
            //{
            //    MainPageViewModel = informationListViewModel,
            //    ImageViewModel = imageListViewModel
            //};

            var mainPageImageInDb = _context.MainPage.Take(2).Include(c => c.Images).ToList();
            var mainPageViewModel = new List<MainPageViewModel>();

            Mapper.Map(mainPageImageInDb, mainPageViewModel);

            return View(mainPageViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}