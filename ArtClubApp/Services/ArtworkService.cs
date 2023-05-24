using ArtClubApp.Models;
using ArtClubApp.Repository.Interfaces;
using System.Linq.Expressions;

    namespace ArtClubApp.Services
    {
        public class ArtworkService : BaseServices
        {
            public ArtworkService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
            public List<Artwork> GetArtworks()
            {
                return repositoryWrapper.artworkRepository.FindAll().ToList();
            }
            public List<Artwork> GetAdminsByCondition(Expression<Func<Artwork, bool>> expression)
            {
                return repositoryWrapper.artworkRepository.FindByCondition(expression).ToList();
            }
            public void AddArtwork(Artwork artwork)
            {
                repositoryWrapper.artworkRepository.Create(artwork);
            }
            public void UpdateArtwork(Artwork artwork)
            {
                repositoryWrapper.artworkRepository.Update(artwork);
            }

            public void DeleteArtwork(Artwork artwork)
            {
                repositoryWrapper.artworkRepository.Delete(artwork);
            }
        }
    }

