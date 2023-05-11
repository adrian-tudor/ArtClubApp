using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using System.Linq.Expressions;

    namespace ArtClubApp.Services
    {
        public class AdminService : BaseServices
        {
            public AdminService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
            public List<Admin> GetAdmins()
            {
                return repositoryWrapper.adminRepository.FindAll().ToList();
            }
            public List<Admin> GetAdminsByCondition(Expression<Func<Admin, bool>> expression)
            {
                return repositoryWrapper.adminRepository.FindByCondition(expression).ToList();
            }
            public void AddAdmin(Admin admin)
            {
                repositoryWrapper.adminRepository.Create(admin);
            }
            public void UpdateAdmin(Admin admin)
            {
                repositoryWrapper.adminRepository.Update(admin);
            }

            public void DeleteAdmin(Admin admin)
            {
                repositoryWrapper.adminRepository.Delete(admin);
            }
        }
    }

