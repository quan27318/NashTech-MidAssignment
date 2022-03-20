using BackEnd.Models;

namespace BackEnd.Services{
    public interface IUserServices{
        public List<User> GetUsers();
        public void CreateUser(User user);
        
    }
}