using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantBackend.Core.Entities;


namespace RestaurantBackend.Infrastructure.DB;

public class EFDDBContext : IdentityDbContext<IdentityUser>
{
    public EFDDBContext(DbContextOptions<EFDDBContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>();
        base.OnModelCreating(modelBuilder);
    }
}
