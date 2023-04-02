using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projecta.Core.Entities;
using Projecta.Core.Repositories;

namespace Projecta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoicesController(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        // GET: api/Invoices
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var invoices = await _invoiceRepository.GetAllAsync();
            return Ok(invoices);
        }

        // GET: api/Invoices/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var invoice = await _invoiceRepository.GetByIdAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }
            return Ok(invoice);
        }

        // POST: api/Invoices
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _invoiceRepository.AddAsync(invoice);
            return CreatedAtAction(nameof(GetById), new { id = invoice.Id }, invoice);
        }

        // PUT: api/Invoices/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != invoice.Id)
            {
                return BadRequest();
            }

            await _invoiceRepository.UpdateAsync(invoice);
            return NoContent();
        }

        // DELETE: api/Invoices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var invoice = await _invoiceRepository.GetByIdAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }

            await _invoiceRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
