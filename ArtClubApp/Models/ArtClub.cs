using System.ComponentModel.DataAnnotations;

namespace ArtClubApp.Models
{
    public class ArtClub
    {
        [Key]
        public int Event_id { get; set; }
        public string Event_name { get; set; }
        public string Event_location { get; set; }
        public DateTime Event_time { get; set; }
    }
}
