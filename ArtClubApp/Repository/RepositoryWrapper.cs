using ArtClubApp.Repository.Interfaces;
using ArtClubApp.Data;
namespace ArtClubApp.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ArtClubContext _context;
        private IAdminRepository AdminRepository;
        private IUserRepository UserRepository;
        private IEventRepository EventRepository;
        private IArtworkRepository ArtworkRepository;
        private IContactRepository ContactRepository;
        private IExhibitionHallRepository ExhibitionHallRepository;
        private IPaymentRepository PaymentRepository;
        private IResourcesRepository ResourcesRepository;

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


        public IEventRepository eventRepository
        {
            get
            {

                if (EventRepository == null)
                {
                    EventRepository = new EventRepository(_context);
                }
                return EventRepository;
            }
        }

        public IArtworkRepository artworkRepository
        {
            get
            {
                if (ArtworkRepository == null)
                {
                    ArtworkRepository = new ArtworkRepository(_context);
                }
                return ArtworkRepository;
            }
        }

        public IContactRepository contactRepository
        {
            get
            {
                if(ContactRepository == null)
                {
                    ContactRepository = new ContactRepository(_context);
                }
                return ContactRepository;
            }
        }

        public IExhibitionHallRepository exhibitionHallRepository
        {
            get
            {
                if (ExhibitionHallRepository == null)
                {
                    ExhibitionHallRepository = new ExhibitionHallRepository(_context);
                }
                return ExhibitionHallRepository;
            }
        }

        public IPaymentRepository paymentRepository
        {
            get
            {
                if (PaymentRepository == null)
                {
                    PaymentRepository = new PaymentRepository(_context);
                }
                return PaymentRepository;
            }
        }

        public IResourcesRepository resourcesRepository
        {
            get
            {
                if (ResourcesRepository == null)
                {
                    ResourcesRepository = new ResourcesRepository(_context);
                }
                return ResourcesRepository;
            }
        }
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