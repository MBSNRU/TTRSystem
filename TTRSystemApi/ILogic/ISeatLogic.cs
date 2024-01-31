using TTRSystemApi.Models;

namespace TTRSystemApi.ILogic
{
    public interface ISeatLogic
    {
        List<Seat> GetSeats();
        Seat GetSeatById(int id);
        bool InsertSeat(Seat seat);
        bool UpdateSeat(Seat seat);
        bool DeleteSeat(int id);
    }
}
