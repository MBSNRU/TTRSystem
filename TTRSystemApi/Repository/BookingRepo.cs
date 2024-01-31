using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Repository
{
    public class BookingRepo : IBookingRepo
    {
        private readonly TtrsContext dbContext;

        public BookingRepo(TtrsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeleteBooking(int id)
        {
            var exi = dbContext.Bookings.Where(x=>x.Id == id).FirstOrDefault();
            if(exi == null) { return false; }
            dbContext.Bookings.Remove(exi);
            dbContext.SaveChanges();
            return true;
        }

        public Booking GetBookingById(int id)
        {
            return dbContext.Bookings.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Booking> GetBookings()
        {
            return dbContext.Bookings.ToList();
        }

        public bool InsertBooking(Booking booking)
        {
            dbContext.Bookings.Add(booking);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateBooking(Booking booking)
        {
            var exi = dbContext.Bookings.Where(x=>x.Id==booking.Id).FirstOrDefault();
            if (exi == null) { return false; }
            //exi.UserId = booking.UserId;
            //exi.SeatId = booking.SeatId;
            //exi.BookingDate = booking.BookingDate;
            exi.PaymentStatus = booking.PaymentStatus;
            dbContext.SaveChanges();
            return true;

        }
    }
}
