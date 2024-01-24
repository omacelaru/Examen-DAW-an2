using Examen.Models.Base;

namespace Examen.Models.Student
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public int Points { get; set; }
    }
}
