using Microsoft.EntityFrameworkCore;
using Projecta.Core.Entities;
using Projecta.Core.Repositories;
using Projecta.Infrastructure.Data;

namespace Proposala.Infrastructure.Repositories
{
    public class ProposalRepository : IProposalRepository
    {
        private readonly ProjectaDbContext _context;

        public ProposalRepository(ProjectaDbContext context)
        {
            _context = context;
        }

        public async Task<Proposal> GetByIdAsync(int id)
        {
            return await _context.Proposals.FindAsync(id);
        }

        public async Task<IEnumerable<Proposal>> GetAllAsync()
        {
            return await _context.Proposals.ToListAsync();
        }

        public async Task AddAsync(Proposal proposal)
        {
            await _context.Proposals.AddAsync(proposal);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Proposal proposal)
        {
            _context.Proposals.Update(proposal);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var proposal = await _context.Proposals.FindAsync(id);
            if (proposal != null)
            {
                _context.Proposals.Remove(proposal);
                await _context.SaveChangesAsync();
            }
        }
    }
}