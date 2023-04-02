using Projecta.Core.Entities;

namespace Projecta.Core.Repositories
{
    public interface ILineItemRepository
    {
        Task<LineItem> GetByIdAsync(int id);

        Task<IEnumerable<LineItem>> GetAllAsync();

        Task AddAsync(LineItem lineItem);

        Task UpdateAsync(LineItem lineItem);

        Task DeleteAsync(int id);
    }
}