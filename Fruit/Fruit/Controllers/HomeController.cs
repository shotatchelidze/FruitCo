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
            var mainPageAndImageInDb = _context.MainPage.Include(c => c.Images).ToList();
            var mainPageViewModel = new List<MainPageViewModel>();

            Mapper.Map(mainPageAndImageInDb, mainPageViewModel);

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