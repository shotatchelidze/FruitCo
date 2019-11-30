using Fruit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fruit.ViewModels;
using AutoMapper;
using System.Data.Entity;
using System.IO;

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
            var informationInDb = _context.Information.ToList().Skip(2).Take(2);
            var IngredientInDb = _context.Ingredient.ToList();
            var imagePathInDb = _context.ImagePath.ToList();

            var informationListViewModel = new List<InformationViewModel>();
            var IngredientListVIewModel = new List<IngredientViewModel>();
            var imagePathViewModel = new List<GalleryPhotoViewModel>();

            Mapper.Map(informationInDb, informationListViewModel);
            Mapper.Map(IngredientInDb, IngredientListVIewModel);
            Mapper.Map(imagePathInDb, imagePathViewModel);

            var commonViewModel = new CommonViewModel
            {
                InformationViewModelList = informationListViewModel,
                IngredientViewModelList = IngredientListVIewModel,
                GalleryPhotoViewModels = imagePathViewModel
            };
             
            return View(commonViewModel);
        }

        // GET: Admin/Drink/UpdateForm
        public ActionResult FormInformation()
        {
            var informationInDb = _context.Information.ToList().Skip(2).Take(2);
            
            var informationListViewModel = new List<InformationViewModel>();
            
            Mapper.Map(informationInDb, informationListViewModel);
            
            return View(informationListViewModel);
        }

        [HttpPost]
        public ActionResult UpdateInformation(List<InformationViewModel> informationViewModels)
        {
            foreach (var informationViewModelsItem in informationViewModels)
            {
                var informationInDb = _context.Information.SingleOrDefault(c => c.Id == informationViewModelsItem.Id);

                Mapper.Map(informationViewModelsItem, informationInDb);
            }
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Drink");
        }

        // GET: Admin/Drink/FormIngredient
        public ActionResult FormIngredient()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddIngredient(IngredientViewModel ingredientViewModel)
        {

            var ingredientInDb = new Ingredient();

            if (ingredientViewModel.Id == 0)
            {
                Mapper.Map(ingredientViewModel, ingredientInDb);
            }
            
            _context.Ingredient.Add(ingredientInDb);
            _context.SaveChanges();
            
            return RedirectToAction("Index","Drink");
        }

        
        public ActionResult DeleteIngredient(int ingredientId)
        {
            var ingredientInDb = _context.Ingredient.SingleOrDefault(c => c.Id == ingredientId);

            if (ingredientInDb == null)
            {
                return HttpNotFound();
            }

            _context.Ingredient.Remove(ingredientInDb);
            _context.SaveChanges();

            return RedirectToAction("Index", "Drink"); 
        }


        public ActionResult GalleryForm()
        {
            return View();
            
        }

        [HttpPost]
        public ActionResult GalleryForm(IEnumerable<HttpPostedFileBase> images)
        {
            foreach (var item in images)
            {
                var physicalPath = Path.Combine(Server.MapPath("~/Images/GalleryImages"), Path.GetFileName(item.FileName));

                item.SaveAs(physicalPath);

                var serverPath = "/Content/Images/" + item.FileName;



            }

            //Images images = new Images();
            //images.File = path;

            _context.SaveChanges();

            return RedirectToAction("Index", "Drink");

        }
    }
}
