using Microsoft.AspNetCore.Mvc;

namespace DockerExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        private static int visitorCount = 0;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var visitorCountLocal = Interlocked.Increment(ref visitorCount);
            _logger.LogError(message: $"count : {visitorCount}");
            return $"Hello! Today's visitor : {visitorCountLocal}";
        }
    }
}