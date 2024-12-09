using Microsoft.EntityFrameworkCore;
using Product_Domain.Model;

namespace product_Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<productModel> product { get; set; }
    }
}
