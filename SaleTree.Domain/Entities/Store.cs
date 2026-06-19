using SaleTree.Domain.Common;

namespace SaleTree.Domain.Entities;

public class Store : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public string? LogoUrl { get; set; }

    public bool IsActive { get; set; } = true;

    /*
     * Foreign Keys
     */

    public string OwnerId { get; set; } = string.Empty;

    /*
     * Navigation Properties
     */

    public ApplicationUser Owner { get; set; } = null!;

    public ICollection<Product> Products { get; set; }
        = new List<Product>();
}
