using TTRSystemApi.ILogic;
using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Logic
{
    public class StationLogic : IStationLogic
    {
        private readonly IStationRepo repo;

        public StationLogic(IStationRepo repo)
        {
            this.repo = repo;
        }
        public bool DeleteStation(int id)
        {
            return repo.DeleteStation(id);
        }

        public Station GetStationByName(string name)
        {
            return repo.GetStationByName(name);
        }

        public List<Station> GetStations()
        {
            return repo.GetStations();
        }

        public bool InsertStation(Station station)
        {
            return repo.InsertStation(station);
        }

        public bool UpdateStation(Station station)
        {
            return repo.UpdateStation(station);
        }
    }
}
