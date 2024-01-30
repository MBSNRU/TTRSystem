using TTRSystemApi.Models;

namespace TTRSystemApi.ILogic
{
    public interface IStationLogic
    {
        List<Station> GetStations();

        Station GetStationByName(string name);

        bool InsertStation(Station station);

        bool UpdateStation(Station station);

        bool DeleteStation(int id);
    }
}
