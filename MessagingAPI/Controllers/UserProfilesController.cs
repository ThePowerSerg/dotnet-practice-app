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
            var userProfiles = await userProfileService.GetUserProfiles();
            return Ok(userProfiles);
        }

        // GET api/userprofiles/1
        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<UserProfile>>> GetById(int Id)
        {
            var userProfile = await userProfileService.GetUserProfileById(Id);
            return Ok(userProfile);
        }

        // Add User

        // Update User

        // Delete User

    }
}