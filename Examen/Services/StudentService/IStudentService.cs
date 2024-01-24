using Examen.Models.Student;

namespace Examen.Services.StudentService
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<Student> CreateStudent(Student student);
        Task<Student> DeleteStudent(string name);
        Task<Student> GetByNameAsync(string name);
        Task<Student> UpdateStudent(Student student);
    }
}
