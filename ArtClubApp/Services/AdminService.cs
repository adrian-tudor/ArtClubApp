using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using global::ArtClubApp.Models;
using global::ArtClubApp.Repository.Interfaces;
using System.Linq.Expressions;

    namespace ArtClubApp.Services
    {
        public class AdminService : BaseServices
        {
            public AdminService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
            public List<Admin> GetUsers()
            {
                return repositoryWrapper.adminRepository.FindAll().ToList();
            }
            public List<Admin> GetUsersByCondition(Expression<Func<Admin, bool>> expression)
            {
                return repositoryWrapper.adminRepository.FindByCondition(expression).ToList();
            }
            public void AddUser(Admin admin)
            {
                repositoryWrapper.adminRepository.Create(admin);
            }
            public void UpdateUser(Admin admin)
            {
                repositoryWrapper.adminRepository.Update(admin);
            }

            public void DeleteUser(Admin admin)
            {
                repositoryWrapper.adminRepository.Delete(admin);
            }
        }
    }

