using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Solid.Core.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Web.Net.API.Models;

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IMKService _mKService;
        private readonly IPartyService _partyService;
        private readonly IToDoService _toDoService;

        public AuthController(IConfiguration configuration, IMKService mKService, IPartyService partyService, IToDoService toDoService)
        {
            _configuration = configuration;
            _mKService = mKService;
            _partyService = partyService;
            _toDoService = toDoService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            // var user = _userService.GetByNameAndPassword(loginModel.UserName, loginModel.Password);
            //if (user is not null)
                if (loginModel.UserName.Equals("tamar") && loginModel.Password.Equals("123456"))
                {
                    var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "tamar"),
                new Claim(ClaimTypes.Role, "admin")
            };

                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWT:Key")));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var tokeOptions = new JwtSecurityToken(
                        issuer: _configuration.GetValue<string>("JWT:Issuer"),
                        audience: _configuration.GetValue<string>("JWT:Audience"),
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(6),
                        signingCredentials: signinCredentials
                    );
                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                    return Ok(new { Token = tokenString });
                
            }
            return Unauthorized();
        }
    }

}
