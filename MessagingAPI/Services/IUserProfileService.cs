using MessagingAPI.Models;

namespace MessagingAPI.Services
{
    // abstraction layer defines how this is going to behave
    public interface IUserProfileService
    {
        // Get all
        Task<IEnumerable<UserProfile>> GetUserProfiles();

        // Get By Id
        Task<UserProfile> GetUserProfileById(int Id);
    }
}