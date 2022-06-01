using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebTokens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        { }
    }
}
