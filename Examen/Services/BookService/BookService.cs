using AutoMapper;
using Examen.Models.Book;
using Examen.Models.Book.Dto;
using Examen.Repositories.BookRepository;

namespace Examen.Services.BookService
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookResponseDto>> GetBooks()
        {
            var books = await _bookRepository.FindAllBooksAsync();
            var booksDto = _mapper.Map<IEnumerable<BookResponseDto>>(books);
            return booksDto;
        }

        public async Task<BookResponseDto> CreateBook(BookRequestDto book)
        {
            var newBook = _mapper.Map<Book>(book);
            await _bookRepository.CreateAsync(newBook);
            var newBookDto = _mapper.Map<BookResponseDto>(newBook);
            return newBookDto;
        }
    }
}