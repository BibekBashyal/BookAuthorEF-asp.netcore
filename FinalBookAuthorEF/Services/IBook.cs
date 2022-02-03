using FinalBookAuthorEF.Models;
using System.Collections.Generic;

namespace FinalBookAuthorEF
{
    public interface IBook
    {
        public IEnumerable<Book> GetAllBook();
        public void DeleteAsBook(int id);
        public void InsertBook(Book book);
        public void EditBook(Book book);
        Book GetBook(long id);
        
    }
}
