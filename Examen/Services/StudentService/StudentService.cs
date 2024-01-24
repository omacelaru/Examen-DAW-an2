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

        public async Task<Student> DeleteStudent(string name)
        {
            var student = await _studentRepository.GetByNameAsync(name);
            _studentRepository.Delete(student);
            await _studentRepository.SaveAsync();
            return student;
        }

        public async Task<Student> GetByNameAsync(string name)
        {
            return await _studentRepository.GetByNameAsync(name);
        }

        public async Task<Student> UpdateStudent(Student student)
        {
            _studentRepository.Update(student);
            await _studentRepository.SaveAsync();
            return student;
        }

    }
}