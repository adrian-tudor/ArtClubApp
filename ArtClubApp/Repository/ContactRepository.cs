using ArtClubApp.Data;
using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;

    namespace ArtClubApp.Repository
    {
        public class ContactRepository : RepositoryBase<Contact>, IContactRepository
        {
            public ContactRepository(ArtClubContext dbContext) : base(dbContext) { }
        }
    }

