using Microsoft.AspNetCore.Mvc;
using Projecta.Core.Repositories;

namespace Projecta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalsController : ControllerBase
    {
        private readonly IProposalRepository _proposalRepository;

        public ProposalsController(IProposalRepository proposalRepository)
        {
            _proposalRepository = proposalRepository;
        }
    }
}