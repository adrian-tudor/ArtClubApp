using System.ComponentModel.DataAnnotations;

namespace ArtClubApp.Models
{
    public class Contact
    {
        [Key]
        public int Message_id { get; set; }

        public string? First_name { get; set; }

        public string? Last_name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public ArtClub? ArtClub { get; set; }

        public int user_id;

        public ICollection<User> user { get; set; }
    }
}
