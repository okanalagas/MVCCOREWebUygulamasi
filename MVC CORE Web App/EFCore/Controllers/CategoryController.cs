using EFCore.Models.Context;
using EFCore.Models.Entities;
using EFCore.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.Controllers
{
    public class CategoryController : Controller
    {
        MyContext _db;
        public CategoryController(MyContext db)   //middlewaredeki tanımlamaya ulaşarak instance alıyor ve dependency injectiona getiriyor
        {
            _db = db;
        }
        public ActionResult GetCategories() 
        {
            return View(_db.Categories.ToList());
        }       
        
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Category item)
        {
            _db.Categories.Add(item);
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }
        public ActionResult UpdateCategory(int id)
        {            
            return View(_db.Categories.Find(id));
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category item)
        {
            Category toBeUpdated = _db.Categories.Find(item.Id);
            toBeUpdated.CategoryName=item.CategoryName;
            toBeUpdated.Description=item.Description;
            toBeUpdated.ModifiedDate = DateTime.Now;
            toBeUpdated.Status = DataStatus.Updated;
            _db.SaveChanges();      
            return RedirectToAction("GetCategories");
        }
        public IActionResult DeleteCategory(int id)
        {
            _db.Categories.Remove(_db.Categories.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }
    }
}
