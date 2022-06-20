using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurantBackend.Infrastructure.DB;
using RestaurantBackend.Infrastructure.Interfaces.Services;
using RestaurantBackend.Infrastructure.Model;
using RestaurantBackend.Infrastructure.Services;


namespace RestaurantBackend.Web;

public class Startup

{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        
        services.AddDbContext<EFDDBContext>(options =>
            options.UseSqlServer("Server=ALEX\\SQLEXPRESS; User Id=dev; Password=111; Database=RestaurantBackend;"));

        services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<EFDDBContext>();

        services.AddScoped<UserManager<IdentityUser>>();
        services.AddScoped<IUserService, UserService>();
    }   

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Configure the HTTP request pipeline.
        
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        //app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(
            endpoints =>
            {
                endpoints.MapControllers();
            });
    }
}