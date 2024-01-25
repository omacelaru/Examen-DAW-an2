using Examen.Models.Book.Dto;

namespace Examen.Models.Author.Dto.WithBooks
{
    public class AuthorWithBooksResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookResponseDto> Books { get; set; }
    }
}
