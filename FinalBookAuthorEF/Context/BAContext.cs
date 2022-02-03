using FinalBookAuthorEF.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalBookAuthorEF.Context
{
    public class BAContext:DbContext
    {
        public BAContext(DbContextOptions<BAContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
