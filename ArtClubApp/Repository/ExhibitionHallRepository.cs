using ArtClubApp.Data;
using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;

    namespace ArtClubApp.Repository
    {
        public class ExhibitionHallRepository : RepositoryBase<ExhibitionHall>, IExhibitionHallRepository
        {
            public ExhibitionHallRepository(ArtClubContext dbContext) : base(dbContext) { }
        }
    }
