using TTRSystemApi.Models;

namespace TTRSystemApi.ILogic
{
    public interface IBookingLogic
    {
        List<Booking> GetBookings();
        Booking GetBookingById(int id);

        bool InsertBooking(Booking booking);
        bool UpdateBooking(Booking booking);
        bool DeleteBooking(int id);
    }
}
