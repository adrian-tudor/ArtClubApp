namespace ArtClubApp.Models
{
    public class Admin
    {
        public int admin_id { get; set; }
        public ICollection<ArtClub>? Artclub { get; set; }

        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public Contact Contact { get; set; }
    }
}
