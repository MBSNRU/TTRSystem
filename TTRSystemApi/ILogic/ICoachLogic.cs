using TTRSystemApi.Models;

namespace TTRSystemApi.ILogic
{
    public interface ICoachLogic
    {
        List<Coach> GetCoaches();
        Coach GetCoachByName(string name);
        bool InsertCoach(Coach coach);
        bool UpdateCoach(Coach coach);
        bool DeleteCoach(int id);
    }
}
