using MessagingAPI.Data;
using MessagingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MessagingAPI.Services
{
    // Implement service
    public class UserProfileService(MessagingApiContext context) : IUserProfileService
    {
        public async Task<IEnumerable<UserProfile>> GetUserProfilesAsync()
        {
            return await context.UserProfiles.ToListAsync();
        }
        public Task<UserProfile?> GetUserProfileByIdAsync(int id) =>
            context.UserProfiles
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);

    }
}
