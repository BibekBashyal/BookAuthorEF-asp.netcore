using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalBookAuthorEF.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public DateTime DateofBirth { get; set; }
        public decimal PhoneNumber { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
        
}
