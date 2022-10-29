using Microsoft.AspNetCore.Mvc;
using System; //Using for Uri
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

[Route("api/[controller]")]  //Auth Management
[ApiController]
[Produces("application/json")]
public class AuthManagementController : ControllerBase
{
  private readonly UserManager<IdentityUser> _userManager;
  private readonly JwtConfig _jwtConfig;

  public AuthManagementController(UserManager<IdentityUser> userManager, IOptionsMonitor<JwtConfig> optionsMonitor)
  {
    _userManager = userManager;
    _jwtConfig = optionsMonitor.CurrentValue;
  }

  [HttpPost]
  [Route("Register")]
  public async Task<IActionResult> Register([FromBody] UserRegistrationRequestDto user)
  {
    if (Model.State.IsValid)
    {
      var existingUser = await _userManager.FindByEmailAsync(user.Email);

      if(existingUser != null)
      {
        return BadRequest(new RegistrationResponse() {
          Result = false,
          Errors = new List<string>() {
            "Email already exists"
          }
        });
      }

      var newUser = new IdentityUser(){Email = existingUser.Email, UserName = user.Email};
      var isCreated = await _userManager.CreateAsync(newUser, user.Password);
      if(isCreated.Succeeded)
      {
        var jwtToken = GenerateJwtToken(newUser);
        return Ok(new RegistrationResponse() {
          Result = true,
          Token = jwtToken
        });
      }

      return new JsonResult(new RegistrationResponse() {
        Result = false,
        Errors = isCreated.Errors.Select(x => x.Description).ToList()
      })
      {StatusCode = 500};
    }

      return BadRequest(new RegistrationResponse() {
        Result = false,
        Errors = new List<string>() {
          "Invalid payload"
    }});
  }
    private string GenerateJwtToken(IdentityUser user)
    {
      // Define the jwt token responsible for creating our tokens
      var jwtTokenHandler = new Jwt
    }
}