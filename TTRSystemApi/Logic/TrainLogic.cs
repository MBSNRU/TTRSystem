using TTRSystemApi.ILogic;
using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Logic
{
    public class TrainLogic : ITrainLogic
    {
        private readonly ITrainRepo repo;

        public TrainLogic(ITrainRepo repo)
        {
            this.repo = repo;
        }
        public bool DeleteTrain(int id)
        {
            return repo.DeleteTrain(id);
        }

        public Train GetTrainByNumber(int number)
        {
            return repo.GetTrainByNumber(number);
        }

        public List<Train> GetTrains()
        {
            return repo.GetTrains();
        }

        public bool InsertTrain(Train train)
        {
            return repo.InsertTrain(train);
        }

        public bool UpdateTrain(Train train)
        {
            return repo.UpdateTrain(train);
        }
    }
}
