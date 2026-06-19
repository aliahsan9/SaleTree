namespace SaleTree.Application.DTOs.Store;

public sealed class CreateStoreRequest
{
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public string? LogoUrl { get; set; }
}
