using Microsoft.EntityFrameworkCore;
using shop.Core.Domain;

namespace shop.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options)
            : base(options) { }
        public DbSet<Product> Product { get; set; }
        public DbSet<ExistingFilePath> ExistingFilePaths { get; set; }
        public DbSet<Spaceship> Spaceship { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<FileToDatabase> FileToDatabase { get; set; }
    }
}
