using ContainerLab.Api.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace ContainerLab.Api.Controllers
{
    [ApiController]
    [Route("api/parkings")]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingRepository _parkingRepository;

        public ParkingController(IParkingRepository parkingRepository)
        {
            _parkingRepository = parkingRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetParkingById(int id)
        {
            var result = await _parkingRepository.GetParkingByIdAsync(id);

            return Ok(result);
        }
    }
}