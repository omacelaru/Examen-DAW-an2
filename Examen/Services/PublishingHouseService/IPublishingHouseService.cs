using Examen.Models.PublishingHouse.Dto;
using Examen.Repositories.BookRepository;

namespace Examen.Services.PublishingHouseService
{
    public interface IPublishingHouseService
    {
        Task<IEnumerable<PublishingHouseResponseDto>> GetPublishingHouses();
        Task<PublishingHouseResponseDto> CreatePublishingHouse(PublishingHouseRequestDto publishingHouse);
    }
}