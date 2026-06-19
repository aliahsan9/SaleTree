using SaleTree.Domain.Common;

namespace SaleTree.Domain.Entities;

public sealed class Review : BaseEntity
{
    public Guid ProductId { get; set; }

    public Guid UserId { get; set; }

    public int Rating { get; set; }

    public string Comment { get; set; } = string.Empty;

    public Product Product { get; set; } = null!;
}
