using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using System.Linq.Expressions;
namespace ArtClubApp.Services
{
    public class PaymentService : BaseServices
        {
        public PaymentService Object { get; }

        public PaymentService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }


        public List<Payment> GetPayments(Payment payment)
            {
                return repositoryWrapper.paymentRepository.FindAll().ToList();
            }
            public List<Payment> GetAdminsByCondition(Expression<Func<Payment, bool>> expression)
            {
                return repositoryWrapper.paymentRepository.FindByCondition(expression).ToList();
            }
            public void AddPayment(Payment payment)
            {
                repositoryWrapper.paymentRepository.Create(payment);
            }
            public void UpdatePayment(Payment payment)
            {
                repositoryWrapper.paymentRepository.Update(payment);
            }

            public void DeletePayment(Payment payment)
            {
                repositoryWrapper.paymentRepository.Delete(payment);
            }

        public float Tax(Payment p)
        {

            return  30 * p.Payment_Total;

        }
    }
    }
