using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using ArtClubApp.Data;

namespace ArtClubApp.Repository
{
    public class AdminRepository : RepositoryBase<Admin>, IAdminRepository
    {
        public AdminRepository(ArtClubContext dbContext) : base(dbContext) { }
    }
}

