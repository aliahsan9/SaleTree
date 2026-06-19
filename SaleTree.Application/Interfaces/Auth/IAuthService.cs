using SaleTree.Application.DTOs.Auth;

namespace SaleTree.Application.Interfaces.Auth;

public interface IAuthService
{
    Task<AuthResponse> RegisterAsync(
        RegisterRequest request);

    Task<AuthResponse> LoginAsync(
        LoginRequest request);
}
