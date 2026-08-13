using MessagingAPI.Dtos;
using MessagingAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MessagingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfilesController(IUserProfileService userProfileService) : ControllerBase
    {
        // GET api/UserProfile
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserProfileDto>>> Get()
        {
            var userProfiles = await userProfileService.GetUserProfilesAsync();
            return Ok(userProfiles);
        }

        // GET api/userprofiles/1
        [HttpGet("{id:int:min(1)}")]
        public async Task<ActionResult<UserProfileDto>> GetById(int id)
        {
            var userProfile = await userProfileService.GetUserProfileByIdAsync(id);

            if (userProfile == null) return NotFound();

            return Ok(userProfile);
        }

        // Add User

        // Update User

        // Delete User

    }
}
