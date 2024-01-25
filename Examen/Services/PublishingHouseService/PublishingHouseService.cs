using AutoMapper;
using Examen.Models.PublishingHouse;
using Examen.Models.PublishingHouse.Dto;
using Examen.Repositories.BookRepository;

namespace Examen.Services.PublishingHouseService
{
    public class PublishingHouseService : IPublishingHouseService
    {
        private readonly IPublishingHouseRepository _publishingHouseRepository;
        private readonly IMapper _mapper;

        public PublishingHouseService(IPublishingHouseRepository publishingHouseRepository, IMapper mapper)
        {
            _publishingHouseRepository = publishingHouseRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PublishingHouseResponseDto>> GetPublishingHouses()
        {
            var publishingHouses = await _publishingHouseRepository.FindAllPublishingHousesAsync();
            var publishingHousesDto = _mapper.Map<IEnumerable<PublishingHouseResponseDto>>(publishingHouses);
            return publishingHousesDto;
        }

        public async Task<PublishingHouseResponseDto> CreatePublishingHouse(PublishingHouseRequestDto publishingHouse)
        {
            var newPublishingHouse = _mapper.Map<PublishingHouse>(publishingHouse);
            await _publishingHouseRepository.CreateAsync(newPublishingHouse);
            await _publishingHouseRepository.SaveAsync();
            var newPublishingHouseDto = _mapper.Map<PublishingHouseResponseDto>(newPublishingHouse);
            return newPublishingHouseDto;
        }
    }
}