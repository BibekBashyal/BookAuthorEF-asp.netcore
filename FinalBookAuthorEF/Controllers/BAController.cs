using FinalBookAuthorEF.Context;
using FinalBookAuthorEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalBookAuthorEF.Controllers
{
    public class BAController : Controller
    {
       IBook  b;
        private readonly BAContext _context;

        
        public BAController(IBook _book, BAContext context)
        {
                b = _book;
            _context = context;
        }
        public IActionResult Index()
        {
            return View(b.GetAllBook());
        }
        public IActionResult Delete(int id)
        {
            b.DeleteAsBook(id);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            
            ViewData["AuthorIdList"] = new SelectList(_context.Authors, "AuthorId", "AuthorName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
           
            b.InsertBook(book);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(long id)
        {
            ViewData["AuthorIdList"] = new SelectList(_context.Authors,"AuthorName","AuthorName");
            Book book = b.GetBook(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {   
            b.EditBook(book);
            return RedirectToAction("Index");
        }
        public IActionResult Details(long id)
        {
            Book book = b.GetBook(id);
            return View(book);
        }

    }
}
           
             
