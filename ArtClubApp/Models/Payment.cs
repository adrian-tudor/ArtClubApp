using System.ComponentModel.DataAnnotations;

namespace ArtClubApp.Models
{
    public class Payment
    {
        [Key]
        public int Payment_Id { get; set; }
        public float Payment_Total { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<Admin>? Admins { get; set; }
        public ICollection<ExhibitionHall>? ExhibitionHalls { get; set; }
        public ICollection<Artwork>? Artworks { get; set; }

    }
}
