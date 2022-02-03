using FinalBookAuthorEF.Context;
using FinalBookAuthorEF.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FinalBookAuthorEF.Services
{
    public class AuthorServices : IAuthor
    {
        private BAContext db;
        public AuthorServices(BAContext _db)
        {
            db = _db;
        }
        public IEnumerable<Author> GetAllAuthor()
        {
            return (db.Authors.ToList());
        }
        public void InsertAuthor(Author author)
        {

            db.Add(author);
            db.SaveChanges();


        }
    }
}
