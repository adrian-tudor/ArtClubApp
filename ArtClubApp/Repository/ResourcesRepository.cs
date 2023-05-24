using ArtClubApp.Data;
using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;

namespace ArtClubApp.Repository
{
    public class ResourcesRepository : RepositoryBase<Resources>, IResourcesRepository
    {
        public ResourcesRepository(ArtClubContext dbContext) : base(dbContext) { }
    }
}
