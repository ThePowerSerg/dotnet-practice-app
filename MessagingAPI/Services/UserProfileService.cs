using MessagingAPI.Data;
using MessagingAPI.Dtos;
using Microsoft.EntityFrameworkCore;

namespace MessagingAPI.Services
{
    // Implement service
    public class UserProfileService(MessagingApiContext context) : IUserProfileService
    {
        public async Task<IEnumerable<UserProfileDto>> GetUserProfilesAsync()
        {
            return await context.UserProfiles
                .AsNoTracking()
                .Select(profile => new UserProfileDto
                {
                    Id = profile.Id,
                    UserName = profile.UserName,
                    Email = profile.Email,
                    PhoneNumber = profile.PhoneNumber,
                    Country = profile.Country
                })
                .ToListAsync();
        }
        public Task<UserProfileDto?> GetUserProfileByIdAsync(int id) =>
            context.UserProfiles
                .AsNoTracking()
                .Where(profile => profile.Id == id)
                .Select(profile => new UserProfileDto
                {
                    Id = profile.Id,
                    UserName = profile.UserName,
                    Email = profile.Email,
                    PhoneNumber = profile.PhoneNumber,
                    Country = profile.Country
                })
                .FirstOrDefaultAsync();

    }
}
