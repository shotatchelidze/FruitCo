using AutoMapper;
using Fruit.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fruit.ViewModels;
using System.IO;

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
            var informationInDb = _context.MainPage.ToList().Take(2);

            var informationListViewModel = new List<MainPageViewModel>();

            Mapper.Map(informationInDb, informationListViewModel);

            return View(informationListViewModel);
        }

        [HttpPost]
        public ActionResult Update(List<MainPageViewModel> model)
        {
            
            foreach (var item in model)
            {
                var informationInDb = _context.MainPage.SingleOrDefault(c => c.Id == item.Id);
                //informationInDb.Title = item.Title;
                //informationInDb.Subtitle = item.Subtitle;
                //informationInDb.Description = item.Description;
                Mapper.Map(item, informationInDb);
            }
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Main");
            
        }

        // GET: Admin/Main
        public ActionResult BackgroundImageForm()
        {

            return View();
        }

        [HttpPost]
        public ActionResult BackgroundImageForm(ImageViewModel model)
        {
            if (model != null)
            {
                var physicalPath = Path.Combine(Server.MapPath("~/Images/BackgroundImages"), Path.GetFileName(model.ImageUpload.FileName));

                model.ImageUpload.SaveAs(physicalPath);
                
                var serverPath = "/Images/BackgroundImages/" + model.ImageUpload.FileName;
                var sortIndex = model.SortIndex;

                //var imageViewModel = new ImageViewModel()
                //{
                //    ImagePath = serverPath,
                //    SortIndex = sortIndex
                //};

                //var image = new Image();
                //Mapper.Map(imageViewModel, image);

                var image = new Image
                {
                    ImagePath = serverPath,
                    SortIndex = sortIndex
                };

                _context.ImagePath.Add(image);
            }
            
            _context.SaveChanges();

            return RedirectToAction("Index","Main");
        }
    }
}