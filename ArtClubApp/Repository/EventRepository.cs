using ArtClubApp.Data;
using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;


namespace ArtClubApp.Repository
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(ArtClubContext dbContext) : base(dbContext) { }
    }
}
