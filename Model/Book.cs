using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDemo.Model
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int BookId {  get; set; }

        [Required]
        public string? BookName { get; set; }

        [Required]
        public string? BookAuthor { get; set; }

        [Required]
        public int BookPrice { get; set; }  
    }
}
