using Examen.Models.Base;

namespace Examen.Models.BookAuthor
{
    public class BookAuthor
    {
        public Guid BookId { get; set; }
        public Book.Book Book { get; set; }
        public Guid AuthorId { get; set; }
        public Author.Author Author { get; set; }
    }
}
