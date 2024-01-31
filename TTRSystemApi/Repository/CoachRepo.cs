using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Repository
{
    public class CoachRepo : ICoachRepo
    {
        private readonly TtrsContext dbContext;

        public CoachRepo(TtrsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeleteCoach(int id)
        {
            var exiCoa = dbContext.Coaches.Where(x=>x.Id == id).FirstOrDefault();
            if(exiCoa == null) { return false; }
            dbContext.Coaches.Remove(exiCoa);
            dbContext.SaveChanges();
            return true;
        }

        public Coach GetCoachByName(string name)
        {
            return dbContext.Coaches.Where(x => x.Name == name).FirstOrDefault();
        }

        public List<Coach> GetCoaches()
        {
            return dbContext.Coaches.ToList();
        }

        public bool InsertCoach(Coach coach)
        {
            dbContext.Coaches.Add(coach);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateCoach(Coach coach)
        {
            var exiCoa = dbContext.Coaches.Where(x=>x.Id ==coach.Id).FirstOrDefault();
            if(exiCoa == null) { return false; }
            exiCoa.Name = coach.Name;
            exiCoa.ClassId = coach.ClassId;
            dbContext.SaveChanges();
            return true;
        }
    }
}
