using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projecta.Core.Entities;
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

        // GET: api/Proposals
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var proposals = await _proposalRepository.GetAllAsync();
            return Ok(proposals);
        }

        // GET: api/Proposals/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var proposal = await _proposalRepository.GetByIdAsync(id);
            if (proposal == null)
            {
                return NotFound();
            }
            return Ok(proposal);
        }

        // POST: api/Proposals
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Proposal proposal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _proposalRepository.AddAsync(proposal);
            return CreatedAtAction(nameof(GetById), new { id = proposal.Id }, proposal);
        }

        // PUT: api/Proposals/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Proposal proposal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != proposal.Id)
            {
                return BadRequest();
            }

            await _proposalRepository.UpdateAsync(proposal);
            return NoContent();
        }

        // DELETE: api/Proposals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var proposal = await _proposalRepository.GetByIdAsync(id);
            if (proposal == null)
            {
                return NotFound();
            }

            await _proposalRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
