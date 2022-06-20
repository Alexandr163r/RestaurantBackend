using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantBackend.Core.Entities.Restaurants;

public class Table : BaseEntity

{
    public string Description { get; set; } = String.Empty;

    public int SeatNumber { get; set; }
    
    public decimal Price { get; set; }

    public bool TableClosed { get; set; }
    
    public Guid RestaurantId { get; set; }

    public Restaurant Restaurant { get; set; }
}