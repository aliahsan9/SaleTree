using SaleTree.Application.DTOs.Product;

namespace SaleTree.Application.Interfaces.Product;

public interface ICategoryService
{
    Task<CategoryDto> CreateAsync(
        CreateCategoryRequest request);

    Task<IEnumerable<CategoryDto>> GetAllAsync();
}
