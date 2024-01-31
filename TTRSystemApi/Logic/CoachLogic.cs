using TTRSystemApi.ILogic;
using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Logic
{
    public class CoachLogic : ICoachLogic
    {
        private readonly ICoachRepo repo;

        public CoachLogic(ICoachRepo repo)
        {
            this.repo = repo;
        }
        public bool DeleteCoach(int id)
        {
            return repo.DeleteCoach(id);
        }

        public Coach GetCoachByName(string name)
        {
            return repo.GetCoachByName(name);
        }

        public List<Coach> GetCoaches()
        {
            return repo.GetCoaches();
        }

        public bool InsertCoach(Coach coach)
        {
            return repo.InsertCoach(coach);
        }

        public bool UpdateCoach(Coach coach)
        {
            return repo.UpdateCoach(coach);
        }
    }
}
