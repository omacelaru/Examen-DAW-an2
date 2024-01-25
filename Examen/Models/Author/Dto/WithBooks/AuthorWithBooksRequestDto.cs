using Examen.Models.Book.Dto;

namespace Examen.Models.Author.Dto.WithBooks
{
    public class AuthorWithBooksRequestDto
    {
        public string Name { get; set; }
        public ICollection<BookRequestDto> Books { get; set; }
    }
}
