using BackEnd.Models;
using BackEnd.Responsitory;

namespace BackEnd.Services{
    public class UserServices : IUserServices
    {
        private readonly  IUserResponsitory _userRespons;
        public UserServices(IUserResponsitory userRespons)
        {
            _userRespons = userRespons;
        }
        public void CreateUser(User user)
        {
            _userRespons.CreateUser(user);
        }

        public List<User> GetUsers()
        {
            return _userRespons.GetUsers();
        }
    }
}