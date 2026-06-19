using Microsoft.AspNet.Identity.EntityFramework;

namespace SaleTree.Domain.Entities;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string? ProfileImageUrl { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAtUtc { get; set; }

    /*
     * Navigation Properties
     */

    public Store? Store { get; set; }
}
