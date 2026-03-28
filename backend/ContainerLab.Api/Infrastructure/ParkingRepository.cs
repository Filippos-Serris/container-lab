using ContainerLab.Api.Model;

namespace ContainerLab.Api.Infrastructure
{
    public class ParkingRepository : IParkingRepository
    {
        private readonly ContainerLabDbContext _context;

        public ParkingRepository(ContainerLabDbContext context)
        {
            _context = context;
        }

        public async Task<Parking> GetParkingByIdAsync(int id)
        {
            var parking = await _context.Parkings.FindAsync(id);
            return parking;
        }
    }
}