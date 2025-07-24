using FormulariosAPI.Common;
using FormulariosAPI.Modules.Auth.Dtos;
using FormulariosAPI.Modules.Auth.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FormulariosAPI.Modules.Auth;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ApiController
{

    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] AuthRequest request)
    {
        var result = await _authService.Login(request);

        return result.Match<IActionResult>(
            result => Ok(result),
            errors => Problem(errors));
    }

    [HttpPost("Register")]
    [Authorize(Roles = "Administrator")]
    public async Task<IActionResult> Register([FromBody] RegistrationRequest request)
    {

        var result = await _authService.Register(request);

        return result.Match<IActionResult>(
            result => Ok(result),
            errors => Problem(errors));

    }

}
