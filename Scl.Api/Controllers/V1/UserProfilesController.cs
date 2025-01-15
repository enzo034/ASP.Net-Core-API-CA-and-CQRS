using MediatR;
using Microsoft.AspNetCore.Mvc;
using Scl.Api.Contracts.UserProfile.Requests;

namespace Scl.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController] 
    public class UserProfilesController : Controller
    {
        private readonly IMediator _mediator;

        public UserProfilesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public UserProfilesController()
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProfiles()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserProfile([FromBody] UserProfileCreate profile)
        {
            return Ok();
        }
    }
}
