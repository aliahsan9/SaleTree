using SaleTree.Domain.Common;
using SaleTree.Domain.Enums;

namespace SaleTree.Domain.Entities;

public class Product : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }

    public ProductStatus Status { get; set; }
        = ProductStatus.Draft;

    public bool IsActive { get; set; } = true;

    /*
     * Foreign Keys
     */

    public int CategoryId { get; set; }

    public int StoreId { get; set; }

    /*
     * Navigation Properties
     */

    public Category Category { get; set; } = null!;

    public Store Store { get; set; } = null!;

    public ICollection<ProductImage> Images { get; set; }
        = new List<ProductImage>();
}
