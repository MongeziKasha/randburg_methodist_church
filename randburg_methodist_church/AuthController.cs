using Microsoft.AspNetCore.Mvc;
using randburg_methodist_church_DAL;
using randburg_methodist_church_Services;

namespace randburg_methodist_church
{   
    public class AuthController : ControllerBase
    {
        private readonly IRandMethAdminService _randMethAdminService;
        private readonly JwtService _jwtService;

        public AuthController(IRandMethAdminService randMethAdminService, JwtService jwtService)
        {
            _randMethAdminService = randMethAdminService;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var admin = await _randMethAdminService.GetByUsernameAsync(request.Username);
            if (admin == null || !BCrypt.Net.BCrypt.Verify(request.Password, admin.PasswordHash))
            {
                return Unauthorized("Invalid username or password");
            }

            var token = _jwtService.GenerateToken(admin.Username);
            return Ok(new { Token = token });
        }
    }
}
