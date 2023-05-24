using System.ComponentModel.DataAnnotations;

namespace ArtClubApp.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public Event? ArtClub { get; set; }

        public ICollection<User> Users { get; set; }
        public int User_id { get; set; }
    }
}
