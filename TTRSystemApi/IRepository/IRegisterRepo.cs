using TTRSystemApi.Models;

namespace TTRSystemApi.IRepository
{
    public interface IRegisterRepo
    {
        List<User> GetUsers();
        User GetUserByUsername(string username);

        bool InsertUser(User user);

        bool UpdateUser(User user);

        bool DeleteUser(int id);
    }
}
