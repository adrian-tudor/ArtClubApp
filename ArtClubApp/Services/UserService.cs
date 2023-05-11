using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using System.Linq.Expressions;

namespace ArtClubApp.Services
{
    public class UserService : BaseServices
    {
        public UserService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
        public List<User> GetUsers()
        {
            return repositoryWrapper.userRepository.FindAll().ToList();
        }
        public List<User> GetUsersByCondition(Expression<Func<User, bool>> expression)
        {
            return repositoryWrapper.userRepository.FindByCondition(expression).ToList();
        }
        public void AddUser(User user)
        {
            repositoryWrapper.userRepository.Create(user);
        }
        public void UpdateUser(User user)
        {
            repositoryWrapper.userRepository.Update(user);
        }

        public void DeleteUser(User user)
        {
            repositoryWrapper.userRepository.Delete(user);
        }
    }
}
