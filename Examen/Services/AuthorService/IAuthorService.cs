using Examen.Models.Author.Dto;
using Examen.Models.Author.Dto.WithBooks;

namespace Examen.Services.AuthorService
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorResponseDto>> GetAuthors();
        Task<AuthorResponseDto> CreateAuthor(AuthorRequestDto author);
        Task<AuthorWithBooksResponseDto> CreateAuthorWithBooks(AuthorWithBooksRequestDto author);
    }
}
