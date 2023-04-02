using Microsoft.EntityFrameworkCore;
using Projecta.Core.Entities;
using Projecta.Core.Repositories;
using Projecta.Infrastructure.Data;

namespace Projecta.Infrastructure.Repositories
{
    public class LineItemRepository : ILineItemRepository
    {
        private readonly ProjectaDbContext _context;

        public LineItemRepository(ProjectaDbContext context)
        {
            _context = context;
        }

        public async Task<LineItem> GetByIdAsync(int id)
        {
            return await _context.LineItems.FindAsync(id);
        }

        public async Task<IEnumerable<LineItem>> GetAllAsync()
        {
            return await _context.LineItems.ToListAsync();
        }

        public async Task AddAsync(LineItem lineItem)
        {
            await _context.LineItems.AddAsync(lineItem);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(LineItem lineItem)
        {
            _context.LineItems.Update(lineItem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var lineItem = await _context.LineItems.FindAsync(id);
            if (lineItem != null)
            {
                _context.LineItems.Remove(lineItem);
                await _context.SaveChangesAsync();
            }
        }
    }
}