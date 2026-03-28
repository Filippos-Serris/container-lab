using ContainerLab.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace ContainerLab.Api.Infrastructure
{
    public class ContainerLabDbContext : DbContext
    {
        public ContainerLabDbContext(DbContextOptions<ContainerLabDbContext> options) : base(options)
        {
        }

        public DbSet<Parking> Parkings { get; set; }
    }
}