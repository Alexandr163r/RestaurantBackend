using Microsoft.AspNetCore.Identity;
using RestaurantBackend.Core.Enums;

namespace RestaurantBackend.Infrastructure.Model;

public class User : IdentityUser
{
    public string Name { get; set; } = String.Empty;
    
    public string Surname { get; set; } = String.Empty;
    
    public string Password { get; set; } = String.Empty;
    
    public string Phone { get; set; } = String.Empty;
    
    public DateTimeOffset ModifiedOn { get; set; }
    
    public DateTimeOffset CreatefiedOn { get; set; }
}