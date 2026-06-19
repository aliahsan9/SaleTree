using SaleTree.Domain.Common;

namespace SaleTree.Domain.Entities;

public sealed class Cart : BaseEntity
{
    public Guid UserId { get; set; }

    public ICollection<CartItem> Items { get; set; }
        = new List<CartItem>();
}
