using ArtClubApp.Data;
using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;

  namespace ArtClubApp.Repository
    {
        public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
        {
            public PaymentRepository(ArtClubContext dbContext) : base(dbContext) { }
        }
    }

