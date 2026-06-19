using SaleTree.Application.DTOs.Product;

namespace SaleTree.Application.Interfaces.Product;

public interface IProductService
{
    Task<ProductDto> CreateAsync(
        CreateProductRequest request);

    Task<ProductDto?> GetByIdAsync(
        int id);

    Task<IEnumerable<ProductDto>> GetAllAsync();
}
