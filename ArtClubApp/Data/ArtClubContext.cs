using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ArtClubApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtClubApp.Data
{
    public class ArtClubContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ArtClub> ArtClub { get; set;}

    }
}
