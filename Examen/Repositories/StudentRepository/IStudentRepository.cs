using Examen.Models.Student;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.StudentRepository
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
    }
}
