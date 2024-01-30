using TTRSystemApi.Models;

namespace TTRSystemApi.IRepository
{
    public interface IStationRepo
    {
        List<Station> GetStations();

        Station GetStationByName(string name);

        bool InsertStation(Station station);

        bool UpdateStation(Station station);

        bool DeleteStation(int id);
    }
}
