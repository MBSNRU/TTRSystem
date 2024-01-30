using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Repository
{
    public class StationRepo : IStationRepo
    {
        private readonly TtrsContext dbContext;

        public StationRepo(TtrsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeleteStation(int id)
        {
            var existingStation = dbContext.Stations.Where(x=>x.Id == id).FirstOrDefault();
            if(existingStation == null) { return false; }
            dbContext.Stations.Remove(existingStation);
            dbContext.SaveChanges();
            return true;
        }

        public Station GetStationByName(string name)
        {
            return dbContext.Stations.Where(x => x.Name == name).FirstOrDefault();
        }

        public List<Station> GetStations()
        {
            return dbContext.Stations.ToList();
        }

        public bool InsertStation(Station station)
        {
            dbContext.Stations.Add(station);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateStation(Station station)
        {
            var existingStation = dbContext.Stations.Where(x=>x.Id==station.Id).FirstOrDefault();
            if (existingStation == null) { return false; }
            existingStation.Name = station.Name;
            existingStation.Code = station.Code;
            existingStation.City = station.City;
            existingStation.State = station.State;
            dbContext.SaveChanges();
            return true;
        }
    }
}
