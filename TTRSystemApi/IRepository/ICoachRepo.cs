using TTRSystemApi.Models;

namespace TTRSystemApi.IRepository
{
    public interface ICoachRepo
    {
        List<Coach> GetCoaches();
        Coach GetCoachByName(string name);
        bool InsertCoach(Coach coach);
        bool UpdateCoach(Coach coach);
        bool DeleteCoach(int id);
    }
}
