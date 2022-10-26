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
        public IActionResult Create(UserDTO dto)
        {
            Result result = _authService.Create(dto);
            if (result.IsFailed) return StatusCode(400);
            return Ok();
        } 
    }
}
