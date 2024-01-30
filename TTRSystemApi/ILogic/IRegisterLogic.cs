using TTRSystemApi.Models;

namespace TTRSystemApi.ILogic
{
    public interface IRegisterLogic
    {
        List<User> GetUsers();
        User GetUserByUsername(string username);

        bool InsertUser(User user);

        bool UpdateUser(User user);

        bool DeleteUser(int id);
    }
}
