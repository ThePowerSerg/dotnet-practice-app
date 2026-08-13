using MessagingAPI.Models;
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
        public async Task<ActionResult<IEnumerable<UserProfile>>> Get()
        {
            var userProfiles = await userProfileService.GetUserProfilesAsync();
            return Ok(userProfiles);
        }

        // GET api/userprofiles/1
        [HttpGet("{id:int:min(1)}")]
        public async Task<ActionResult<UserProfile>> GetById(int Id)
        {
            var userProfile = await userProfileService.GetUserProfileByIdAsync(Id);

            if (userProfile == null) return NotFound();

            return Ok(userProfile);
        }

        // Add User

        // Update User

        // Delete User

    }
}