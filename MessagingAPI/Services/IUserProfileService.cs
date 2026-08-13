using MessagingAPI.Dtos;

namespace MessagingAPI.Services
{
    // abstraction layer defines how this is going to behave
    public interface IUserProfileService
    {
        // Get all
        Task<IEnumerable<UserProfileDto>> GetUserProfilesAsync();

        // Get By Id
        Task<UserProfileDto?> GetUserProfileByIdAsync(int id);
    }
}
