using FinalBookAuthorEF.Models;
using System.Collections.Generic;

namespace FinalBookAuthorEF.Services
{
    public interface IAuthor
    {
        public IEnumerable<Author> GetAllAuthor();
        public void InsertAuthor(Author author);

    }
}
