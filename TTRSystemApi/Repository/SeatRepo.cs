using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Repository
{
    public class SeatRepo : ISeatRepo
    {
        private readonly TtrsContext dbContext;

        public SeatRepo(TtrsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeleteSeat(int id)
        {
            var exiSea= dbContext.Seats.Where(x=>x.Id == id).FirstOrDefault();
            if(exiSea == null) { return false; }
            dbContext.Seats.Remove(exiSea);
            dbContext.SaveChanges();
            return true;
        }

        public Seat GetSeatById(int id)
        {
            return dbContext.Seats.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Seat> GetSeats()
        {
            return dbContext.Seats.ToList();
        }

        public bool InsertSeat(Seat seat)
        {
            dbContext.Seats.Add(seat);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateSeat(Seat seat)
        {
            var exiSea= dbContext.Seats.Where(x=>x.Id==seat.Id).FirstOrDefault();
            if(exiSea == null) { return false; }
            //exiSea.Number = seat.Number;
            exiSea.Availability = seat.Availability;
            //exiSea.CoachId = seat.CoachId;
            //exiSea.TrainId = seat.TrainId;
            dbContext.SaveChanges();
            return true;
        }
    }
}
