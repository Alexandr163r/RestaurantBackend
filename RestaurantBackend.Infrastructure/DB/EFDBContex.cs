using Microsoft.EntityFrameworkCore;
using RestaurantBackend.Core.Entities;
using RestaurantBackend.Core.Entities.Bookings;
using RestaurantBackend.Core.Entities.Geo;
using RestaurantBackend.Core.Entities.Restaurants;

namespace RestaurantBackend.Infrastructure.DB;

public class EFDDBContext : DbContext
{
    public EFDDBContext(DbContextOptions<EFDDBContext> options) : base(options)
    {
    }
    
    public DbSet<BookingHall> BookingHalls { get; set; }
    
    public DbSet<BookingTable> BookingTables { get; set; }
    
    public DbSet<Address> Addresses { get; set; }
    
    public DbSet<City> Cities { get; set; }
    
    public DbSet<Country> Countries { get; set; }
    
    public DbSet<Region> Regions { get; set; }

    public DbSet<Hall> Halls { get; set; }
    
    public DbSet<Restaurant> Restaurants { get; set; }
    
    public DbSet<RestaurantNetwork> RestaurantNetworks { get; set; }
    
    public DbSet<Table> Tables { get; set; }
    
    public DbSet<UserEntity> UserEntities { get; set; }
}