using ArtClubApp.Data;
using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;


    namespace ArtClubApp.Repository
    {
        public class ArtworkRepository : RepositoryBase<Artwork>, IArtworkRepository
        {
            public ArtworkRepository(ArtClubContext dbContext) : base(dbContext) { }
            
        public  Artwork GetArtworkById(int id)
        {
            var artwork = dbContext.Artworks.FirstOrDefault(x => x.Artwork_Id == id);
                return artwork;
        }
        }
    }
