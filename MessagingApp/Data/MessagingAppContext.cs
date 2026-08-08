using MessagingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MessagingApp.Data
{
    public class MessagingAppContext : DbContext
    {
        private readonly DbContextOptions _options;
        public DbSet<UserProfile> userProfiles { get; set; }

        public MessagingAppContext(DbContextOptions options)
        {
            this._options = options;
        }
    }
}