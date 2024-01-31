using TTRSystemApi.ILogic;
using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Logic
{
    public class BookingLogic : IBookingLogic
    {
        private readonly IBookingRepo repo;

        public BookingLogic(IBookingRepo repo)
        {
            this.repo = repo;
        }
        public bool DeleteBooking(int id)
        {
            return repo.DeleteBooking(id);
        }

        public Booking GetBookingById(int id)
        {
            return repo.GetBookingById(id);
        }

        public List<Booking> GetBookings()
        {
            return repo.GetBookings();
        }

        public bool InsertBooking(Booking booking)
        {
            return repo.InsertBooking(booking);
        }

        public bool UpdateBooking(Booking booking)
        {
            return repo.UpdateBooking(booking);
        }
    }
}
