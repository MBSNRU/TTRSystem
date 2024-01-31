using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Repository
{
    public class TrainStationRepo : ITrainStationRepo
    {
        private readonly TtrsContext dbContext;

        public TrainStationRepo(TtrsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool Delete(int id)
        {
            var exi = dbContext.TrainStations.Where(x=>x.Id == id).FirstOrDefault();
            if(exi== null) { return false; }
            dbContext.TrainStations.Remove(exi);
            dbContext.SaveChanges();
            return true;
        }

        public List<TrainStation> Get()
        {
            return dbContext.TrainStations.ToList();
        }

        public bool Insert(TrainStation trainStation)
        {
            dbContext.TrainStations.Add(trainStation);
            dbContext.SaveChanges();
            return true;
        }

        public bool Update(TrainStation trainStation)
        {
            var exi = dbContext.TrainStations.Where(x=>x.Id==trainStation.Id).FirstOrDefault();
            if(exi == null) { return false; }
            exi.TrainId = trainStation.TrainId;
            exi.StationId = trainStation.StationId;
            exi.StopNumber = trainStation.StopNumber;
            exi.DepartAt = trainStation.DepartAt;
            exi.ArriveAt = trainStation.ArriveAt;
            dbContext.SaveChanges();
            return true;
            
        }
    }
}
