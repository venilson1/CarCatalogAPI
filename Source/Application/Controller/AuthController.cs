using CarCatalogAPI.Source.Core.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogAPI.Source.Application.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(UserDTO dto)
        {
            return Ok(); 
        }
    }
}
