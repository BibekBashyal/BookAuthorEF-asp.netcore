using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalBookAuthorEF.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; } 
        public string BookPrice { get; set; }
        public int AuthorId { get; set; }   
        [ForeignKey("AuthorId")]
        public Author Author { get; set; } 
    }
}
