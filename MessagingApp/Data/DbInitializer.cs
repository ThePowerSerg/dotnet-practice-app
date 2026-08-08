using MessagingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MessagingApp.Data
{
    public static class DbInitializer
    {
        public static void SeedData(MessagingAppContext context)
        {
            // Applies any pending migrations, creating the database/table if needed
            context.Database.Migrate();

            if (context.UserProfiles.Any()) return;

            var userProfiles = new List<UserProfile>()
            {
                new() {
                    UserName = "sergferreira81",
                    Email = "sergferreira81@gmail.com",
                    PhoneNumber = "7817332393"
                },
                new() {
                    UserName = "sergiof810",
                    Email = "sergiof810@outlook.com",
                    PhoneNumber = "7817332393"
                }
            };

            context.UserProfiles.AddRange(userProfiles);

            context.SaveChanges();
        }
    }
}
