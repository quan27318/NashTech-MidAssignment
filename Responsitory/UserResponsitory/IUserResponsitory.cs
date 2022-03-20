using BackEnd.Models;

namespace BackEnd.Responsitory{
    public interface IUserResponsitory {
        public List<User> GetUsers();
        public void CreateUser(User user);
        
    }
}