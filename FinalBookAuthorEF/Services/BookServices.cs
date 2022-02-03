using FinalBookAuthorEF.Context;
using FinalBookAuthorEF.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FinalBookAuthorEF.Services
{
    public class BookServices : IBook
    {
        BAContext db;
        public BookServices(BAContext _db)
        {
            db = _db;
        }
        public void DeleteAsBook(int id)
        {
            Book book = db.Books.FirstOrDefault(x => x.BookId == id);
            if (book!=null)
            {
                db.Remove(book);
                db.SaveChanges();   
            }
        }

        public void EditBook(Book book)
        {
            Book bookedit = db.Books.Include("Author").FirstOrDefault(x => x.BookId == book.BookId);
            bookedit.BookId = book.BookId;
            bookedit.BookName = book.BookName;
            bookedit.BookPrice = book.BookPrice;
            bookedit.Author.AuthorName = book.Author.AuthorName;

            db.SaveChanges();
        }

        public IEnumerable<Book> GetAllBook()
        {
            return(db.Books.Include("Author").ToList());
        }

        public Book GetBook(long id)
        {
            Book book = db.Books.Include("Author").FirstOrDefault(x => x.BookId == id);
            return (book);
        }

        public void InsertBook(Book book)
        {

                db.Add(book);
                db.SaveChanges();
        }

        
    }
}
