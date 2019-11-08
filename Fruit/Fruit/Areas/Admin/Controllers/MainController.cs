using Fruit.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fruit.Areas.Admin.Controllers
{
   

    public class MainController : Controller
    {
        private ApplicationDbContext _context;

        public MainController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Admin/Main
        public ActionResult Index()
        {
            var information = _context.Information.ToList();
            
            return View(information);
        }

        [HttpPost]
        public ActionResult Update(Information information)
        {
            var informationInDb = _context.Information.FirstOrDefault(c => c.Id == information.Id);

            return View();
        }
    }
}