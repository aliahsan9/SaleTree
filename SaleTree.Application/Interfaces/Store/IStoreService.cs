using SaleTree.Application.DTOs.Store;

namespace SaleTree.Application.Interfaces.Store;

public interface IStoreService
{
    Task<StoreDto> CreateAsync(
        string ownerId,
        CreateStoreRequest request);

    Task<StoreDto?> GetByIdAsync(
        int id);
}
