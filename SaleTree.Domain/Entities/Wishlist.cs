using SaleTree.Domain.Common;

namespace SaleTree.Domain.Entities;

public sealed class Wishlist : BaseEntity
{
    public Guid UserId { get; set; }

    public Guid ProductId { get; set; }

    public Product Product { get; set; } = null!;
}
