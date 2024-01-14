using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AdaTech.AdaShop.ApresentationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController()
        {
                
        }

        [HttpGet]
        public Task<ActionResult> Get() {
            return Task.FromResult<ActionResult>(Ok());
        }

        [HttpGet("{id}")]
        public Task<ActionResult> Get([Required]string id)
        {
            return Task.FromResult<ActionResult>(Ok());
        }

        [HttpPost]
        public Task<ActionResult> Post()
        {
            return Task.FromResult<ActionResult>(Ok());
        }

        [HttpPut]
        public Task<ActionResult> Put()
        {
            return Task.FromResult<ActionResult>(Ok());
        }

        [HttpDelete]
        public Task<ActionResult> Delete()
        {
            return Task.FromResult<ActionResult>(Ok());
        }
    }
}
