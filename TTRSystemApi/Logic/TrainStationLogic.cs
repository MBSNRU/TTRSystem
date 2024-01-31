using TTRSystemApi.ILogic;
using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Logic
{
    public class TrainStationLogic : ITrainStationLogic
    {
        private readonly ITrainStationRepo repo;

        public TrainStationLogic(ITrainStationRepo repo)
        {
            this.repo = repo;
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);
        }

        public List<TrainStation> Get()
        {
            return repo.Get();
        }

        public bool Insert(TrainStation trainStation)
        {
            return repo.Insert(trainStation);
        }

        public bool Update(TrainStation trainStation)
        {
            return repo.Update(trainStation);
        }
    }
}
