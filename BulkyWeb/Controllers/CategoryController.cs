using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
             
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList<Category>();
            return View(objCategoryList);
        }
        public IActionResult Create() 
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "DisplayOrder can't exactly match with the Name");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "New Category Item Created Successfully!";
                return RedirectToAction("Index");
            }
            return View();
            
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categuryDb = _db.Categories.Find(id);
            //Category? categuryDb1 = _db.Categories.FirstOrDefault(u=>u.ID == id);
            //Category? categuryDb2 = _db.Categories.Where(u=>u.ID==id).FirstOrDefault();
            if (categuryDb == null)
            {
                return NotFound();
            }

            return View(categuryDb);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {            
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category Item Updated Created Successfully!";
                return RedirectToAction("Index");
            }
            return View();

        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categuryDb = _db.Categories.Find(id);
            if (categuryDb == null)
            {
                return NotFound();
            }

            return View(categuryDb);
        }

        [HttpPost ,ActionName("Delete") ]
        public IActionResult DeletePOST(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();  
            }

            Category? obj = _db.Categories.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category Item Deleted Created Successfully!";
            return RedirectToAction("Index");
            
        }
    }
}
