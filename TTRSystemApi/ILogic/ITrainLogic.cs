using TTRSystemApi.Models;

namespace TTRSystemApi.ILogic
{
    public interface ITrainLogic
    {
        List<Train> GetTrains();
        Train GetTrainByNumber(int number);
        bool InsertTrain(Train train);
        bool UpdateTrain(Train train);
        bool DeleteTrain(int id);
    }
}
