using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using ArtClubApp.Data;

namespace ArtClubApp.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ArtClubContext dbContext) : base(dbContext) { }
    }
}
