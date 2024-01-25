using Examen.Models.Author.Dto;

namespace Examen.Services.AuthorService
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorResponseDto>> GetAuthors();
        Task<AuthorResponseDto> CreateAuthor(AuthorRequestDto author);
    }
}
