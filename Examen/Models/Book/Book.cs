using Examen.Models.Base;

namespace Examen.Models.Book
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public ICollection<BookAuthor.BookAuthor> Authors { get; set; }
    }
}