using System.ComponentModel.DataAnnotations;

namespace ArtClubApp.Models
{
    public class ExhibitionHall
    {
        [Key]
        public int ExhibitionHall_Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public float Rent { get; set; }
    }
}
