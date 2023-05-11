using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtClubApp.Models
{
    [NotMapped]
    public class User : IdentityUser
    {
        [Key]
        public int User_id { get; set; }
        public ICollection<Event> Artclub { get; set; }
        public override string? Email { get; set; }

        public string? Password { get; set; }
        public ICollection<Contact> Contacts { get; set; }

    }
}
