using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using System.Linq.Expressions;

   namespace ArtClubApp.Services
    {
        public class ContactService : BaseServices
        {
            public ContactService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
            public List<Contact> GetContacts()
            {
                return repositoryWrapper.contactRepository.FindAll().ToList();
            }
            public List<Contact> GetAdminsByCondition(Expression<Func<Contact, bool>> expression)
            {
                return repositoryWrapper.contactRepository.FindByCondition(expression).ToList();
            }
            public void AddContact(Contact contact)
            {
                repositoryWrapper.contactRepository.Create(contact);
            }
            public void UpdateContact(Contact contact)
            {
                repositoryWrapper.contactRepository.Update(contact);
            }

            public void DeleteContact(Contact contact)
            {
                repositoryWrapper.contactRepository.Delete(contact);
            }
        }
    }

