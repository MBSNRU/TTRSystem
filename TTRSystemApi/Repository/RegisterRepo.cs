using TTRSystemApi.IRepository;
using TTRSystemApi.Models;

namespace TTRSystemApi.Repository
{
    public class RegisterRepo : IRegisterRepo
    {
        private readonly TtrsContext dbContext;

        public RegisterRepo(TtrsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool DeleteUser(int id)
        {
            var existingUser = dbContext.Users.Where(x=>x.Id == id).FirstOrDefault();
            if (existingUser == null) { return  false; }
            dbContext.Users.Remove(existingUser);
            dbContext.SaveChanges();
            return true;
        }

        public User GetUserByUsername(string username)
        {
            return dbContext.Users.Where(x => x.Username == username).FirstOrDefault();
        }

        public List<User> GetUsers()
        {
            return dbContext.Users.ToList();
        }

        public bool InsertUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateUser(User user)
        {
            var existingUser = dbContext.Users.Where(x => x.Id == user.Id).FirstOrDefault();
            if (existingUser == null) { return false; }
            //existingUser.Username = user.Username;
            existingUser.Password = user.Password;
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            existingUser.Gender = user.Gender;
            existingUser.DateOfBirth = user.DateOfBirth;
            existingUser.Mobile = user.Mobile;
            existingUser.Email = user.Email;
            existingUser.Address = user.Address;
            //existingUser.RoleId = user.RoleId;
            dbContext.SaveChanges();
            return true;


        }

    }
}
