using MessagingAPI.Models;

namespace MessagingAPI.Services
{
    // abstraction layer defines how this is going to behave
    public interface IUserProfileService
    {
        // Get all
        Task<IEnumerable<UserProfile>> GetUserProfilesAsync();

        // Get By Id
        Task<UserProfile?> GetUserProfileByIdAsync(int id);
    }
}