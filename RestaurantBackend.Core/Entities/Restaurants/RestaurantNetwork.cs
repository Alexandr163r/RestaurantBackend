namespace RestaurantBackend.Core.Entities.Restaurants;

public class RestaurantNetwork : BaseEntity

{
    public string Name { get; set; } = String.Empty;
    
    public string Description { get; set; } = String.Empty;
    
    public string Phone { get; set; } = String.Empty;
    
    public string Email { get; set; } = String.Empty;
}