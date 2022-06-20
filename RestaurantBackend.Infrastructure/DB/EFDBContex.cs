using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantBackend.Core.Entities;
using RestaurantBackend.Core.Entities.Geo;
using RestaurantBackend.Infrastructure.Model;

namespace RestaurantBackend.Infrastructure.DB;

public class EFDDBContext : IdentityDbContext<User>
{
    public EFDDBContext(DbContextOptions<EFDDBContext> options) : base(options)
    {
    }

    public DbSet<UserEntity> UserEntities { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>();
        base.OnModelCreating(modelBuilder);
    }
}
