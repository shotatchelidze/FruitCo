using AutoMapper;
using Fruit.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fruit.ViewModels;

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
            var informationInDb = _context.Information.ToList().Take(2);

            var informationListViewModel = new List<InformationViewModel>();

            Mapper.Map(informationInDb, informationListViewModel);

            return View(informationListViewModel);
        }

        [HttpPost]
        public ActionResult Update(List<InformationViewModel> model)
        {
            try
            {
                var informationInDb = _context.Information.ToList();

                Mapper.Map(model, informationInDb);

                _context.SaveChanges();

                return RedirectToAction("Index", "Main");
            }
            catch (Exception ex)
            {
                
                throw;
            }
            //var informationInDb = _context.Information.SingleOrDefault(c => c.Id == model.Id);
            
        }

        
    }
}