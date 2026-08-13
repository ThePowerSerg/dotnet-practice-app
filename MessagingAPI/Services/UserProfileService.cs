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
        public UserProfile GetUserProfileById(int Id)
        {
            return context.UserProfiles.FirstOrDefault(p => p.Id == Id) ?? throw new KeyNotFoundException($"User profile with ID {Id} was not found.");
        }

    }
}