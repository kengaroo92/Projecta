using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projecta.Core.Entities;
using Projecta.Core.Repositories;

namespace Projecta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineItemsController : ControllerBase
    {
        private readonly ILineItemRepository _lineItemRepository;

        public LineItemsController(ILineItemRepository lineItemRepository)
        {
            _lineItemRepository = lineItemRepository;
        }

        // GET: api/LineItems
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var lineItems = await _lineItemRepository.GetAllAsync();
            return Ok(lineItems);
        }

        // GET: api/LineItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var lineItem = await _lineItemRepository.GetByIdAsync(id);
            if (lineItem == null)
            {
                return NotFound();
            }
            return Ok(lineItem);
        }

        // POST: api/LineItems
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] LineItem lineItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _lineItemRepository.AddAsync(lineItem);
            return CreatedAtAction(nameof(GetById), new { id = lineItem.Id }, lineItem);
        }

        // PUT: api/LineItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] LineItem lineItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lineItem.Id)
            {
                return BadRequest();
            }

            await _lineItemRepository.UpdateAsync(lineItem);
            return NoContent();
        }

        // DELETE: api/LineItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var lineItem = await _lineItemRepository.GetByIdAsync(id);
            if (lineItem == null)
            {
                return NotFound();
            }

            await _lineItemRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
