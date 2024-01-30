using TTRSystemApi.Models;

namespace TTRSystemApi.IRepository
{
    public interface ITrainRepo
    {
        List<Train> GetTrains();
        Train GetTrainByNumber(int number);
        bool InsertTrain(Train train);
        bool UpdateTrain(Train train);
        bool DeleteTrain(int id);
    }
}
