using SaleTree.Domain.Common;

namespace SaleTree.Domain.Entities;

public sealed class CartItem : BaseEntity
{
    public Guid CartId { get; set; }

    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public Cart Cart { get; set; } = null!;

    public Product Product { get; set; } = null!;
}
