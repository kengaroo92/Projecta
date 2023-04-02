using Projecta.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.Core.Repositories
{
    public interface IProposalRepository
    {
        Task<Proposal> GetByIdAsync(int id);
        Task<IEnumerable<Proposal>> GetAllAsync();
        Task AddAsync(Proposal proposal);
        Task UpdateAsync(Proposal proposal);
        Task DeleteAsync(int id);
    }
}
