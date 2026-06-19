namespace SaleTree.Application.DTOs.Store;

public sealed class StoreDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public string? LogoUrl { get; set; }

    public string OwnerId { get; set; } = string.Empty;
}
