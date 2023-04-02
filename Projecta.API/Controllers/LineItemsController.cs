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
    }
}
