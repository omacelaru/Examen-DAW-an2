using Examen.Models.PublishingHouse.Dto;
using Examen.Services.PublishingHouseService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PublishingHouseController : ControllerBase
    {
        private readonly IPublishingHouseService _publishingHouseService;

        public PublishingHouseController(IPublishingHouseService publishingHouseService)
        {
            _publishingHouseService = publishingHouseService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PublishingHouseResponseDto>>> GetPublishingHouses()
        {
            var publishingHouses = await _publishingHouseService.GetPublishingHouses();
            return Ok(publishingHouses);
        }

        [HttpPost]
        public async Task<ActionResult<PublishingHouseResponseDto>> CreatePublishingHouse(
            PublishingHouseRequestDto publishingHouse)
        {
            var newPublishingHouse = await _publishingHouseService.CreatePublishingHouse(publishingHouse);
            return Ok(newPublishingHouse);
        }
    }
}