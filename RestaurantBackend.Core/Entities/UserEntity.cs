using RestaurantBackend.Core.Enums;

namespace RestaurantBackend.Core.Entities;

public class UserEntity : BaseEntity
{
    public string Name { get; set; } = String.Empty;
    public string Surname { get; set; } = String.Empty;
    
    public string Email { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
    public string Phone { get; set; } = String.Empty;
}