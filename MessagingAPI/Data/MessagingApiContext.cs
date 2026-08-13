using MessagingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MessagingAPI.Data
{
    public class MessagingApiContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}