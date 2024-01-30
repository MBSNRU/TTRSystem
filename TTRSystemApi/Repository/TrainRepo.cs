using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Repository
{
    public class TrainRepo : ITrainRepo
    {
        private readonly TtrsContext dbContext;

        public TrainRepo(TtrsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeleteTrain(int id)
        {
            var existingTrain = dbContext.Trains.Where(x=>x.Id == id).FirstOrDefault();
            if(existingTrain == null) { return false; }
            dbContext.Trains.Remove(existingTrain);
            dbContext.SaveChanges();
            return true;
        }

        public Train GetTrainByNumber(int number)
        {
            return dbContext.Trains.Where(x => x.Number == number).FirstOrDefault();
        }

        public List<Train> GetTrains()
        {
            return dbContext.Trains.ToList();
        }

        public bool InsertTrain(Train train)
        {
            dbContext.Trains.Add(train);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateTrain(Train train)
        {
            var existingTrain = dbContext.Trains.Where(x=>x.Id==train.Id).FirstOrDefault();
            if(existingTrain == null) { return false; }
            //existingTrain.Number = train.Number;
            existingTrain.Name = train.Name;
            existingTrain.SourceStation = train.SourceStation;
            existingTrain.DestinationStation = train.DestinationStation;
            existingTrain.Description = train.Description;
            dbContext.SaveChanges();
            return true;
        }
    }
}
