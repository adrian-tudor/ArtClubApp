using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using System.Linq.Expressions;

namespace ArtClubApp.Services
{
    public class ResourcesService : BaseServices
    {
        public ResourcesService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
        public List<Resources> GetResources()
        {
            return repositoryWrapper.resourcesRepository.FindAll().ToList();
        }
        public List<Resources> GetEventsByCondition(Expression<Func<Resources, bool>> expression)
        {
            return repositoryWrapper.resourcesRepository.FindByCondition(expression).ToList();
        }
        public void AddResources(Resources resources)
        {
            repositoryWrapper.resourcesRepository.Create(resources);
        }
        public void UpdateUser(Resources resources)
        {
            repositoryWrapper.resourcesRepository.Update(resources);
        }

        public void DeleteUser(Resources resources)
        {
            repositoryWrapper.resourcesRepository.Delete(resources);
        }
    }
}
