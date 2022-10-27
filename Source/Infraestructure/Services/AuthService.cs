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
        private SignInManager<IdentityUser<int>> _signInManager;
        private ITokenService _tokenService;
        public AuthService(UserManager<IdentityUser<int>> userManager, SignInManager<IdentityUser<int>> signInManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task<Result> Create(UserDTO user)
        {
            IdentityUser<int> userIdentity = new IdentityUser<int>
            {
                Email = user.Email,
                UserName = user.Username
            };

            IdentityResult resultIdentity = await _userManager.CreateAsync(userIdentity, user.Password);

            if (resultIdentity.Succeeded) return Result.Ok();

            return Result.Fail("Falha ao cadastrar usuário");
        }

        public async Task<Result> Login(LoginDTO user)
        {
            SignInResult resultIdentity = await _signInManager.PasswordSignInAsync(user.Username, user.Password, false, false);

            if (resultIdentity.Succeeded) 
            {
                var identityUser = _signInManager
                    .UserManager.Users.FirstOrDefault(u => u.NormalizedUserName == user.Username.ToUpper());
                
                TokenEntity token = _tokenService.Create(identityUser);
                
                return Result.Ok().WithSuccess(token.Value);
            } 
            
            return Result.Fail("Falha ao fazer login");
        }
    }
}
