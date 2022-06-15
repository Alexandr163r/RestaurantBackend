using RestaurantBackend.Core.Entities.Geo;

namespace RestaurantBackend.Core.Entities.Restaurants;

public class Restaurant : BaseEntity

{
    public string Description { get; set; } = String.Empty;
    
    public string Email { get; set; } = String.Empty;

    public string Phone { get; set; } = String.Empty;

    public Guid RestaurantNetworkId { get; set; }
    
    public Guid AddressId { get; set; }
}