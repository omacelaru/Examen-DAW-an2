using Examen.Data;
using Examen.Models.Book;
using Examen.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Examen.Repositories.BookRepository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Book>> FindAllBooksAsync()
        {
            return await _table.Include(b => b.Authors).AsNoTracking().ToListAsync();
        }

    }
}