using ArtClubApp.Models;

namespace ArtClubApp.Repository.Interfaces
{
    public interface IArtworkRepository : IRepositoryBase<Artwork>
    {
        Artwork GetArtworkById(int id);
    }
}
