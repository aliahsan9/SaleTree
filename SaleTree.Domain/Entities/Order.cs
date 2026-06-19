using System.Net;

using SaleTree.Domain.Common;
using SaleTree.Domain.Enums;

namespace SaleTree.Domain.Entities;

public sealed class Order : BaseEntity
{
    public Guid UserId { get; set; }

    public Guid AddressId { get; set; }

    public decimal TotalAmount { get; set; }

    public OrderStatus Status { get; set; }

    public Address Address { get; set; } = null!;

    public ICollection<OrderItem> Items { get; set; }
        = new List<OrderItem>();
}
