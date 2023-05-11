using ArtClubApp.Repository.Interfaces;
using ArtClubApp.Data;
namespace ArtClubApp.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ArtClubContext _context;
        private IAdminRepository AdminRepository;
        private IUserRepository UserRepository;

        public IUserRepository userRepository
        {
            get
            {

                if (UserRepository == null)
                {
                    UserRepository = new UserRepository(_context);
                }
                return UserRepository;
            }
        }

        public IAdminRepository adminRepository
        {
            get
            {
                if (AdminRepository == null)
                {
                    AdminRepository = new AdminRepository(_context);
                }
                return AdminRepository;
            }
        }


        public IEventRepository eventRepository => throw new NotImplementedException();

        public IArtworkRepository artworkRepository => throw new NotImplementedException();

        public IContactRepository contactRepository => throw new NotImplementedException();

        public IExhibitionHallRepository exhibitionHallRepository => throw new NotImplementedException();

        public IPaymentRepository paymentRepository => throw new NotImplementedException();

        public IResourcesRepository resourcesRepository => throw new NotImplementedException();

        public RepositoryWrapper(ArtClubContext dbContext)
        {
            _context = dbContext;
        }
        public void Save()
        {

            _context.SaveChanges();

        }

    }
}