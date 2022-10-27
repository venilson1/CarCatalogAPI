using CarCatalogAPI.Source.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace CarCatalogAPI.Source.Core.Interfaces.Services
{
    public interface ITokenService
    {
        TokenEntity Create(IdentityUser<int> user);
    }
}
