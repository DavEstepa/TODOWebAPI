using Microsoft.AspNetCore.Mvc;
using TODOWebAPI.Domain.Entities;

namespace TODOWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class TODOController : ControllerBase
    {

        private readonly ILogger<TODOController> _logger;

        public TODOController(ILogger<TODOController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<TodoDto> Post([FromBody] TodoDto data)
        {
            return data;
        }

    }
}
