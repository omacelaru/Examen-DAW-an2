using Examen.Data;
using Examen.Models.PublishingHouse;
using Examen.Models.PublishingHouse.Dto;
using Examen.Repositories.BookRepository;
using Examen.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Examen.Repositories.PublishingHouseRepository
{
    public class PublishingHouseRepository : GenericRepository<PublishingHouse>, IPublishingHouseRepository
    {
        public PublishingHouseRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PublishingHouse>> FindAllPublishingHousesAsync()
        {
            return await _table.Include(p => p.Authors).AsNoTracking().ToListAsync();
        }
    }
}