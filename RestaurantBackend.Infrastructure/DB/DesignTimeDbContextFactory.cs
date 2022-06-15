using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RestaurantBackend.Infrastructure.DB;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EFDDBContext>
{
    public EFDDBContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<EFDDBContext>();
        
        builder.UseSqlServer(@"Server=ALEX\SQLEXPRESS; User Id=dev; Password=111; Database=RestauranBackend;");       

        return new EFDDBContext(builder.Options);
    }
}