using SaleTree.Domain.Common;

namespace SaleTree.Domain.Entities;

public class Category : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;

    /*
     * Navigation Properties
     */

    public ICollection<Product> Products { get; set; }
        = new List<Product>();

}
