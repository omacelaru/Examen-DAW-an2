using Examen.Models.Book.Dto;

namespace Examen.Services.BookService
{
    public interface IBookService
    {
        Task<IEnumerable<BookResponseDto>> GetBooks();
        Task<BookResponseDto> CreateBook(BookRequestDto book);
    }
}