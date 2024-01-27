using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notification.Microservice.Core.Interfaces;

namespace Notification.Microservice.Core.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RabbitmqController : ControllerBase
    {
        private readonly IProdecer _producer;
        public RabbitmqController(IProdecer prodecer)
        {
            _producer = prodecer;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(string message)
        {
            _producer.Produce(message);
            return Ok();
        }
    }
}
