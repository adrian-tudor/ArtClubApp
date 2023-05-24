using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using System.Linq.Expressions;

namespace ArtClubApp.Services
{
    public class EventService : BaseServices
    {
        public EventService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
        public List<Event> GetEvents()
        {
            return repositoryWrapper.eventRepository.FindAll().ToList();
        }
        public List<Event> GetEventsByCondition(Expression<Func<Event, bool>> expression)
        {
            return repositoryWrapper.eventRepository.FindByCondition(expression).ToList();
        }
        public void AddEvent(Event events)
        {
            repositoryWrapper.eventRepository.Create(events);
        }
        public void UpdateEvent(Event events)
        {
            repositoryWrapper.eventRepository.Update(events);
        }

        public void DeleteEvent(Event events)
        {
            repositoryWrapper.eventRepository.Delete(events);
        }
    }
}

