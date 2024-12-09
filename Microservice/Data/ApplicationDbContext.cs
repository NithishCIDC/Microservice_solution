using Microservice.Domain.Modal;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Customer> Customer { get; set; }
    }
}
