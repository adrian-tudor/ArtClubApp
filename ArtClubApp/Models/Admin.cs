using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtClubApp.Models
{
    [NotMapped]
    public class Admin : IdentityUser
    {
        [Key]
        public int Admin_Id { get; set; }
        public ICollection<Event> Artclub { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Contact Contact { get; set; }
    }
}
