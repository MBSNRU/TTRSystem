using TTRSystemApi.Models;

namespace TTRSystemApi.IRepository
{
    public interface ISeatRepo
    {
        List<Seat> GetSeats();
        Seat GetSeatById(int id);
        bool InsertSeat(Seat seat);
        bool UpdateSeat(Seat seat);
        bool DeleteSeat(int id);
    }
}
