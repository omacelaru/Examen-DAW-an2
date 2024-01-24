using Examen.Data;
using Examen.Models.Student;
using Examen.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Examen.Repositories.StudentRepository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Student> GetByNameAsync(string name)
        {
            return await _table.FirstOrDefaultAsync(s => s.Name == name);
        }
    }
}
