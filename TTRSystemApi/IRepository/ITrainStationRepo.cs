using TTRSystemApi.Models;

namespace TTRSystemApi.IRepository
{
    public interface ITrainStationRepo
    {
        List<TrainStation> Get();
        bool Insert(TrainStation trainStation);
        bool Update(TrainStation trainStation);
        bool Delete(int id);
    }
}
