using Examen.Data;
using Examen.Models.Student;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.StudentRepository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
