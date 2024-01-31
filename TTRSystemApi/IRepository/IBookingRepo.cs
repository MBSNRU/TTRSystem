using TTRSystemApi.Models;

namespace TTRSystemApi.IRepository
{
    public interface IBookingRepo
    {
        List<Booking> GetBookings();
        Booking GetBookingById(int id);

        bool InsertBooking(Booking booking);
        bool UpdateBooking(Booking booking);
        bool DeleteBooking(int id);
    }
}
