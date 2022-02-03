using FinalBookAuthorEF.Models;
using FinalBookAuthorEF.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinalBookAuthorEF.Controllers
{
    public class AuthorController : Controller
    {
        IAuthor a;
        public AuthorController(IAuthor _author)
        {
            a = _author;
        }
        public IActionResult Index()
        {
            return View(a.GetAllAuthor());
        }
        public IActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Author author)
        {
            a.InsertAuthor(author);
            return RedirectToAction("Index");
        }
    }
}
