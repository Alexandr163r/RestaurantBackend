using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RestaurantBackend.Infrastructure.DB;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
        
        builder.UseSqlServer(@"Server=ALEX\SQLEXPRESS; User Id=dev; Password=111; Database=RestaurantBackend;");       

        return new ApplicationDbContext(builder.Options);
    }
}