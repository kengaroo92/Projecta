using Projecta.Core.Entities;

namespace Projecta.Core.Repositories
{
    public interface IInvoiceRepository
    {
        Task<Invoice> GetByIdAsync(int id);

        Task<IEnumerable<Invoice>> GetAllAsync();

        Task AddAsync(Invoice invoice);

        Task UpdateAsync(Invoice invoice);

        Task DeleteAsync(int id);
    }
}