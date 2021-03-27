using System.Threading.Tasks;
using AzureServiceBusViewer.Application.Queries.GetResources;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AzureServiceBusViewer.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResourcesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ResourcesController(IMediator  mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Get([FromQuery] GetResourcesQuery query)
        {
            var result = await _mediator.Send(query);
            
            return Ok(result);
        }
        
    }
}