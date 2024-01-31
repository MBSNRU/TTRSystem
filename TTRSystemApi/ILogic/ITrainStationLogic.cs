using TTRSystemApi.Models;

namespace TTRSystemApi.ILogic
{
    public interface ITrainStationLogic
    {
        List<TrainStation> Get();
        bool Insert(TrainStation trainStation);
        bool Update(TrainStation trainStation);
        bool Delete(int id);
    }
}
