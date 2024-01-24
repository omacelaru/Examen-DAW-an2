using AutoMapper;
using Examen.Models.Student;
using Examen.Models.Student.Dto;
using Examen.Services.StudentService;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentResponseDto>>> GetAllStudent()
        {
            var students = await _studentService.GetAllStudents();
            var studentsResponseDto = _mapper.Map<IEnumerable<StudentResponseDto>>(students);
            return Ok(studentsResponseDto);
        }

        [HttpPost]
        public async Task<ActionResult<StudentResponseDto>> CreateStudent(StudentRequestDto studentRequestDto)
        {
            var student = _mapper.Map<Student>(studentRequestDto);
            var studentCreated = await _studentService.CreateStudent(student);
            var studentResponseDto = _mapper.Map<StudentResponseDto>(studentCreated);
            return Ok(studentResponseDto);
        }
    }
}