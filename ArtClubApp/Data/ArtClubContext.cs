using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ArtClubApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtClubApp.Data
{
    public class ArtClubContext : IdentityDbContext<IdentityUser>
    {
        public ArtClubContext(DbContextOptions<ArtClubContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Artwork> Artworks { get; set;}
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ExhibitionHall> ExhibitionHalls { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Resources> Resources { get; set; }

    }
}
