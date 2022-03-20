using BackEnd.Models;

namespace BackEnd.Responsitory{
    public class UserResponsitory : IUserResponsitory
    {
        private readonly LibraryDbContext _dbContext;
        public UserResponsitory(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }
    }
}