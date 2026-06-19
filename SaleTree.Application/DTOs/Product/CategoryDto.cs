namespace SaleTree.Application.DTOs.Product;

public sealed class CategoryDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }
}
