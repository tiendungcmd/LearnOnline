using LearnOnline.API.Data;
using LearnOnline.API.Services.AuthService;
using LearnOnline.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;
        private readonly LearnOnlineDbContext _learnOnlineDb;

        public AuthController(IAuthService authService, IConfiguration configuration, LearnOnlineDbContext learnOnlineDb)
        {
            _authService = authService;
            _configuration = configuration;
            _learnOnlineDb = learnOnlineDb;
        }
        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegister request)
        {
            var response = await _authService.Register(
                new User
                {
                    Email = request.Email,
                    UserName = request.Email.Split("@")[0]
                },
                request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLogin request)
        {
            var response = await _authService.Login(request.Email, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("change-password")]
        public async Task<ActionResult<ServiceResponse<bool>>> ChangePassword(UserChangePassword newPassword)
        {
            var email = newPassword.UserName + "@gmail.com";
            var user = _learnOnlineDb.Users.FirstOrDefault(x => x.Email == email);
            var response = await _authService.ChangePassword(user.Id, newPassword.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
