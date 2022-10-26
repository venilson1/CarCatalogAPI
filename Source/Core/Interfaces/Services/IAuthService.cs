using CarCatalogAPI.Source.Core.DTOs;
using FluentResults;

namespace CarCatalogAPI.Source.Core.Interfaces.Services
{
    public interface IAuthService
    {
        Task<Result> Create(UserDTO user);
        Task<Result> Login(LoginDTO user);
    }
}
