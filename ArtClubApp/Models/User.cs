using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtClubApp.Models
{
    [NotMapped]
    public class User : IdentityUser
    {
        [Key]
        public int user_id { get; set; }
        public ICollection<ArtClub>? Artclub { get; set; }
        public string? First_name { get; set; }
        public string? Last_name { get; set; }
        public override string? Email { get; set; }

        public string? Password { get; set; }
        public Contact contact { get; set; }

    }
}
