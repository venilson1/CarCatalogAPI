using CarCatalogAPI.Source.Core.DTOs;
using FluentResults;

namespace CarCatalogAPI.Source.Core.Interfaces.Services
{
    public interface IAuthService
    {
        Result Create(UserDTO user);
    }
}
