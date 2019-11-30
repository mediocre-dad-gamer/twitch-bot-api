using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TwitchBotApi.Models;
using TwitchBotApi.Services;

namespace TwitchBotApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessController : ControllerBase
    {
        private readonly ILogger<ProcessController> _logger;
        private readonly Processor _processor;

        public ProcessController(ILogger<ProcessController> logger, Processor processor)
        {
            _logger = logger;
            _processor = processor;
        }

        [HttpPost]
        public async Task<IActionResult> Process([FromBody] TwitchMessage message)
        {
            var result = await _processor.Process(message);
            return Ok(result);
        }
    }
}
