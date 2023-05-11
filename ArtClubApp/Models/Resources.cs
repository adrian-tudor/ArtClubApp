using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace ArtClubApp.Models
{
    public class Resources
    {
        [Key]
        public int Resources_Id { get; set; }
        public ExhibitionHall? ExhibitionHall { get; set; }
        public Artwork? Artwork { get; set; }
    }
}
