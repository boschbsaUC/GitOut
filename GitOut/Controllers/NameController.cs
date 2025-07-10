using Microsoft.AspNetCore.Mvc;

namespace GitOut.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private readonly ILogger<NameController> _logger;
        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetName")]

        public IActionResult Get()
        {
            var returnName = new Name("Samuel");
            return Ok(returnName);
        }
    }
}
