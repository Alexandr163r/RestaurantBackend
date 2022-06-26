using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;

namespace RestaurantBackend.Infrastructure.DB;

public class ApplicationUser : IdentityUser<Guid>
{
    public string Surname { get; set; } = String.Empty; 
}