using System.ComponentModel.DataAnnotations;

namespace ArtClubApp.Models
{
    public class Event
    {
        [Key]
        public int Event_id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Time { get; set; }
    }
}
