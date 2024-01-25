using Examen.Models.Book;
using Examen.Models.PublishingHouse;
using Examen.Models.PublishingHouse.Dto;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.BookRepository
{
    public interface IPublishingHouseRepository : IGenericRepository<PublishingHouse>
    {
        Task<IEnumerable<PublishingHouse>> FindAllPublishingHousesAsync();
    }
}