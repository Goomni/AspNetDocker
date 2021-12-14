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

        [HttpGet("{visitor}")]
        public string Get(string visitor)
        {
            var visitorCountLocal = Interlocked.Increment(ref visitorCount);
            _logger.LogError(message: $"visitor : {visitor} count : {visitorCount}");
            return $"�ȳ��ϼ��� {visitor} ��! ����� �̰��� �湮�� {visitorCountLocal}��° �մ��Դϴ�!";
        }
    }
}