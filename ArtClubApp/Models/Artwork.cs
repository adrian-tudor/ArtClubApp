using System.ComponentModel.DataAnnotations;

namespace ArtClubApp.Models
{
    public class Artwork
    { 
        [Key]
        public int Artwork_Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public float Rent { get; set; }
    }
}
