using SaleTree.Domain.Entities;

namespace SaleTree.Application.Interfaces.Infrastructure;

public interface IJwtTokenGenerator
{
    Task<string> GenerateTokenAsync(
        ApplicationUser user,
        IList<string> roles);
}
