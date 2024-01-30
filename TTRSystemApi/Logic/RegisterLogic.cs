using TTRSystemApi.ILogic;
using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Logic
{
    public class RegisterLogic : IRegisterLogic
    {
        private readonly IRegisterRepo repo;

        public RegisterLogic(IRegisterRepo repo)
        {
            this.repo = repo;
        }
        public bool DeleteUser(int id)
        {
            return repo.DeleteUser(id);
        }

        public User GetUserByUsername(string username)
        {
            return repo.GetUserByUsername(username);
        }

        public List<User> GetUsers()
        {
            return repo.GetUsers();
        }

        public bool InsertUser(User user)
        {
            return repo.InsertUser(user);
        }

        public bool UpdateUser(User user)
        {
            return repo.UpdateUser(user);
        }
    }
}
