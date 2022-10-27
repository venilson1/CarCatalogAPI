using CarCatalogAPI.Source.Core.Entities;
using CarCatalogAPI.Source.Core.Interfaces.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CarCatalogAPI.Source.Infraestructure.Services
{
    public class TokenService : ITokenService
    {
        public TokenEntity Create(IdentityUser<int> user)
        {
            Claim[] claims = new Claim[]
            {
                new Claim("username", user.UserName),
                new Claim("id", user.Id.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("4aaeaa785a4cec250c162292ecb6b9f060c2c82d"));

            var credencials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(claims: claims, signingCredentials: credencials, expires: DateTime.UtcNow.AddHours(1));

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return new TokenEntity(tokenString);
        }
    }
}
