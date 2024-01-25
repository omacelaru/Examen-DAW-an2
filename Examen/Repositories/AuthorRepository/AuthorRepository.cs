using Examen.Data;
using Examen.Models.Author;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.AuthorRepository
{
    public class AuthorRepository: GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
