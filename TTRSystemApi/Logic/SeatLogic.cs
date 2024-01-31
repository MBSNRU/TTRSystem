using TTRSystemApi.ILogic;
using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Logic
{
    public class SeatLogic : ISeatLogic
    {
        private readonly ISeatRepo repo;

        public SeatLogic(ISeatRepo repo)
        {
            this.repo = repo;
        }
        public bool DeleteSeat(int id)
        {
            return repo.DeleteSeat(id);
        }

        public Seat GetSeatById(int id)
        {
            return repo.GetSeatById(id);
        }

        public List<Seat> GetSeats()
        {
            return repo.GetSeats();
        }

        public bool InsertSeat(Seat seat)
        {
            return repo.InsertSeat(seat);
        }

        public bool UpdateSeat(Seat seat)
        {
            return repo.UpdateSeat(seat);
        }
    }
}
