using Examen.Models.Student;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.StudentRepository
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<Student> GetByNameAsync(string name);
    }
}
