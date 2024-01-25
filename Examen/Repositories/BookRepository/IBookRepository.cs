using Examen.Models.Book;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.BookRepository
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<IEnumerable<Book>> FindAllBooksAsync();
    }
}
