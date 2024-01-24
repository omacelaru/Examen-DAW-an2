using AutoMapper;
using Examen.Models.Student;
using Examen.Models.Student.Dto;

namespace Examen.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<Student, StudentResponseDto>();
            CreateMap<StudentRequestDto, Student>();
        }
    }
}
