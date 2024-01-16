using AdaTech.AdaShop.Application.Customer.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdaTech.AdaShop.ApresentationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCustomerCommand command)
        {
            var result = await _mediator.Send(command);
            return StatusCode(201, result);
        }
    }
}
