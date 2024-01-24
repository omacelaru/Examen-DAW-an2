using Examen.Models.Student;
using Examen.Repositories.StudentRepository;

namespace Examen.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _studentRepository.GetAllAsync();
        }

        public async Task<Student> CreateStudent(Student student)
        {
            student.Points = new Random().Next(0, 100);
            await _studentRepository.CreateAsync(student);
            await _studentRepository.SaveAsync();
            return student;
        }
    }
}