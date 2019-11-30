using Microsoft.AspNetCore.Mvc;

namespace TwitchBotApi.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok();
        }
    }
}