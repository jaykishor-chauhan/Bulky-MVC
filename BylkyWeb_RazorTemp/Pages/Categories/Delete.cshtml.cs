using BylkyWeb_RazorTemp.Data;
using BylkyWeb_RazorTemp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BylkyWeb_RazorTemp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if(id != null && id != 0)
            {
                category = _db.Categories.Find(id);
            }
        }
        public IActionResult OnPost()
        {
            Category? obj = _db.Categories.Find(category.ID);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully!";
            return RedirectToPage("Index");

        }
    }
}
