using ArtClubApp.Data;
using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;


    namespace ArtClubApp.Repository
    {
        public class ArtworkRepository : RepositoryBase<Artwork>, IArtworkRepository
        {
            public ArtworkRepository(ArtClubContext dbContext) : base(dbContext) { }
        }
    }
