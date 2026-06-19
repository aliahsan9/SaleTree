using SaleTree.Domain.Common;

namespace SaleTree.Domain.Entities;

public class ProductImage : AuditableEntity
{
    public string ImageUrl { get; set; } = string.Empty;

    public bool IsPrimary { get; set; }

    /*
     * Foreign Key
     */

    public int ProductId { get; set; }

    /*
     * Navigation Property
     */

    public Product Product { get; set; } = null!;
}
