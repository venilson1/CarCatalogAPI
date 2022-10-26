using CarCatalogAPI.Source.Core.DTOs;
using CarCatalogAPI.Source.Core.Entities;
using CarCatalogAPI.Source.Core.Interfaces.Services;
using FluentResults;
using Microsoft.AspNetCore.Identity;

namespace CarCatalogAPI.Source.Infraestructure.Services
{
    public class AuthService : IAuthService
    {
        private UserManager<IdentityUser<int>> _userManager;
        public AuthService(UserManager<IdentityUser<int>> userManager)
        {
            _userManager = userManager;
        }
        public Result Create(UserDTO user)
        {
            IdentityUser<int> userIdentity = new IdentityUser<int>
            {
                Email = user.Email,
                UserName = user.Username
            };

            Task<IdentityResult> resultIdentity = _userManager.CreateAsync(userIdentity, user.Password);

            if (resultIdentity.Result.Succeeded) return Result.Ok();
            return Result.Fail("Falha ao cadastrar usuário");
        }
    }
}
