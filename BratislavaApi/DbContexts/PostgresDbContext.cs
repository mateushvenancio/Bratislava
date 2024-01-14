using BratislavaApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BratislavaApi.DbContexts
{
    public class PostgresDbContext(DbContextOptions<PostgresDbContext> options) : DbContext(options)
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<SaleEntity> Sales { get; set; }
    }
}
