using Fruit.Models;
using System;
using System.Collections.Generic;
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

            return View();
        }
    }
}