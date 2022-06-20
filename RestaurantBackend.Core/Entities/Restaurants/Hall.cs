using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantBackend.Core.Entities.Restaurants;

public class Hall : BaseEntity

{
    public string Description { get; set; } = String.Empty;

    public int SeatNumber { get; set; } 
    
    public decimal Price { get; set; }

    public bool HallClosed { get; set; }

    public Guid RestaurantId { get; set; }
}
    