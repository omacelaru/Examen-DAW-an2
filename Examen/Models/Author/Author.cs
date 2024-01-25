using Examen.Models.Base;

namespace Examen.Models.Author
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<BookAuthor.BookAuthor> Books { get; set; }

        public Guid PublishingHouseId { get; set; }
        public PublishingHouse.PublishingHouse PublishingHouse { get; set; }
    }
}