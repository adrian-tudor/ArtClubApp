using ArtClubApp.Repository.Interfaces;
namespace ArtClubApp.Services {
  public class BaseServices
    {
        protected IRepositoryWrapper repositoryWrapper;

        public BaseServices(IRepositoryWrapper repository)
        {
            repositoryWrapper = repository;
        }

        public void Save()
        {
            repositoryWrapper.Save();
        }
    }
}