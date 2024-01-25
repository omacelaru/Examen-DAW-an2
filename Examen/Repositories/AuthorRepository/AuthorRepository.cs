using Examen.Data;
using Examen.Models.Author;
using Examen.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Examen.Repositories.AuthorRepository
{
    public class AuthorRepository: GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context){
        }

        public async Task<IEnumerable<Author>> FindAllAuthorsAsync()
        {
            return await _table.Include(a => a.Books).AsNoTracking().ToListAsync();
        }
    }
}
