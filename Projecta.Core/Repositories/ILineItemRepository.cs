using Projecta.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
