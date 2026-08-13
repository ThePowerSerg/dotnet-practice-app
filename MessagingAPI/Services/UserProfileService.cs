using MessagingAPI.Data;
using MessagingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MessagingAPI.Services
{
    // Implement service
    public class UserProfileService(MessagingApiContext context) : IUserProfileService
    {
        public async Task<IEnumerable<UserProfile>> GetUserProfiles()
        {
            return await context.UserProfiles.ToListAsync();
        }
        public async Task<UserProfile> GetUserProfileById(int Id)
        {
            return await context.UserProfiles.FirstOrDefaultAsync(p => p.Id == Id) ?? throw new KeyNotFoundException($"User profile with ID {Id} was not found.");
        }

    }
}