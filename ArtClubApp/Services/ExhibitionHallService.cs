using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using ArtClubApp.Repository;
using System.Linq.Expressions;

namespace ArtClubApp.Services
{
    public class ExhibitionHallService : BaseServices
    {
        public ExhibitionHallService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
        public List<ExhibitionHall> GetExhibitionHalls()
        {
            return repositoryWrapper.exhibitionHallRepository.FindAll().ToList();
        }
        public List<ExhibitionHall> GetEventsByCondition(Expression<Func<ExhibitionHall, bool>> expression)
        {
            return repositoryWrapper.exhibitionHallRepository.FindByCondition(expression).ToList();
        }
        public void AddExhibitionHall(ExhibitionHall exhibitionhalls)
        {
            repositoryWrapper.exhibitionHallRepository.Create(exhibitionhalls);
        }
        public void UpdateExhibitionHall(ExhibitionHall exhibitionhalls)
        {
            repositoryWrapper.exhibitionHallRepository.Update(exhibitionhalls);
        }

        public void DeleteExhibitionHall(ExhibitionHall exhibitionhalls)
        {
            repositoryWrapper.exhibitionHallRepository.Delete(exhibitionhalls);
        }
    }
}
