using MessagingAPI.Models;

namespace MessagingAPI.Services
{
    // abstraction layer defines how this is going to behave
    public interface IUserProfileService
    {
        // Get all
        Task<IEnumerable<UserProfile>> GetUserProfiles();

        // Get By Id
        UserProfile GetUserProfileById(int Id);
    }
}