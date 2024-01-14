using AdaTech.AdaShop.Application.Customer.Commands;
using AdaTech.AdaShop.Domain.Infra;
using AdaTech.AdaShop.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AdaTech.AdaShop.ApresentationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly IRepositoryBase<Customer> _repository;
        readonly IMediator _mediator;

        public CustomerController(IRepositoryBase<Customer> repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        [HttpGet]
        public ActionResult Get() {

            var result = _repository.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public Task<ActionResult> Get([Required]string id)
        {
            return Task.FromResult<ActionResult>(Ok());
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody]AddCustomerCommand request)
        {
            var result = await _mediator.Send(request);
            return StatusCode(201, result);
        }

        [HttpPut]
        public Task<ActionResult> Put()
        {
            return Task.FromResult<ActionResult>(Ok());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([Required] string id)
        {
            var command = new DeleteCustomerCommand(id);
            var result = await _mediator.Send(command);

            if (result == false)
            {
                return NotFound();
            }

            return StatusCode(204);
        }
    }
}
