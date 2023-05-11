namespace ArtClubApp.Repository.Interfaces
{
    public interface IRepositoryWrapper
    {
        IAdminRepository adminRepository { get; }
        IArtClubRepository artclubRepository { get; }
        IArtworkRepository artworkRepository { get; }
        IContactRepository contactRepository { get; }
        IExhibitionHallRepository exhibitionHallRepository { get; }
        IPaymentRepository paymentRepository { get; }
        IResourcesRepository resourcesRepository { get; }
        void Save() { }
    }
  
}
