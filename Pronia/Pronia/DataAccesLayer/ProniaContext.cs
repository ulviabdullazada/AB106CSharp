using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pronia.Models;

namespace Pronia.DataAccesLayer
{
    public class ProniaContext : IdentityDbContext
    {
        public ProniaContext(DbContextOptions<ProniaContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        //public DbSet<ProductCategory> ProductCategories { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is BaseEntity entity)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entity.CreatedTime = DateTime.Now;
                            entity.IsDeleted = false;
                            break;
                        case EntityState.Modified:
                            entity.UpdatedTime = DateTime.Now;
                            break;
                    }
                }
            };
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
