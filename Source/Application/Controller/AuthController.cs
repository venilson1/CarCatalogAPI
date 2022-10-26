using CarCatalogAPI.Source.Core.DTOs;
using CarCatalogAPI.Source.Core.Interfaces.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogAPI.Source.Application.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        public AuthController(IAuthService userService)
        {
            _authService = userService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(UserDTO dto)
        {
            Result result = await _authService.Create(dto);
            if (result.IsFailed) return StatusCode(400);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            Result result = await _authService.Login(dto);
            if (result.IsFailed) return Unauthorized();
            return Ok();
        }
    }
}
