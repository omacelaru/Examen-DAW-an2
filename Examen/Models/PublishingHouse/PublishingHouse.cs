using Examen.Models.Base;

namespace Examen.Models.PublishingHouse
{
    public class PublishingHouse : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Author.Author>? Authors { get; set; }
    }
}
