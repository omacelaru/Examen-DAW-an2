using Examen.Data;
using Examen.Models.PublishingHouse;
using Examen.Repositories.BookRepository;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.PublishingHouseRepository
{
    public class PublishingHouseRepository : GenericRepository<PublishingHouse>, IPublishingHouseRepository
    {
        public PublishingHouseRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}