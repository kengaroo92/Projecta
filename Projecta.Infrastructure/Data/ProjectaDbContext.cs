using Microsoft.EntityFrameworkCore;
using Projecta.Core.Entities;

namespace Projecta.Infrastructure.Data
{
    public class ProjectaDbContext : DbContext
    {
        public ProjectaDbContext(DbContextOptions<ProjectaDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<LineItem> LineItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
