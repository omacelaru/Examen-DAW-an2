using Examen.Models.Book;
using Examen.Models.Book.Dto;
using Examen.Services.BookService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService) => _bookService = bookService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookResponseDto>>>GetBooks()
        {
            var books = await _bookService.GetBooks();
            return Ok(books);
        }

        [HttpPost]
        public async Task<ActionResult<BookResponseDto>> CreateBook(BookRequestDto book)
        {
            var newBook = await _bookService.CreateBook(book);
            return Ok(newBook);
        }

    }
}
