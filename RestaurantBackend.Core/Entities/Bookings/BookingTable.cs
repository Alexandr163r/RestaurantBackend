namespace RestaurantBackend.Core.Entities.Bookings;

public class BookingTable : BaseEntity

{
    public Guid TableId { get; set; }

    public int SeatNumber { get; set; }

    public decimal Price { get; set; }
    
    public DateTimeOffset DateTimeBooking { get; set; }
}