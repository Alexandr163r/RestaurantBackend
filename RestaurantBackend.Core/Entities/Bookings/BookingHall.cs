namespace RestaurantBackend.Core.Entities.Bookings;

public class BookingHall : BaseEntity

{
    public int SeatNumber { get; set; }

    public Decimal Price { get; set; }

    public Guid RestaurantId { get; set; }

    public Guid HallId { get; set; }

    public Boolean BookingStatus { get; set; }

    public DateTimeOffset DateTimeBooking { get; set; }
}