using ContainerLab.Api.Model;

namespace ContainerLab.Api.Infrastructure
{
    public interface IParkingRepository
    {
        Task<Parking> GetParkingByIdAsync(int id);
    }
}