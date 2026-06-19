namespace SaleTree.Application.DTOs.Auth;

public sealed class AuthResponse
{
    public string UserId { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty; // User Full Name

    public string Email { get; set; } = string.Empty;

    public string Token { get; set; } = string.Empty;

    public DateTime ExpiresAtUtc { get; set; }

    public IList<string> Roles { get; set; }
        = new List<string>();
}
