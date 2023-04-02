using Projecta.Core.Repositories;
using Projecta.Infrastructure.Data;
using Projecta.Infrastructure.Repositories;
using Proposala.Infrastructure.Repositories;

namespace Projecta.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        // Set up the Dependency Injection container.
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            var services = builder.Services;
            services.AddScoped<ProjectaDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ILineItemRepository, LineItemRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IProposalRepository, ProposalRepository>();
        }
    }
}