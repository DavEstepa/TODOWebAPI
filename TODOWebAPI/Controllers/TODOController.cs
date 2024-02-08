using Microsoft.AspNetCore.Mvc;
using TODOWebAPI.Domain.Entities;
using TODOWebAPI.Domain.Interfaces;
using TODOWebAPI.Repository;

namespace TODOWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class TODOController : ControllerBase
    {

        private readonly ILogger<TODOController> _logger;
        private readonly ITODORepository _repository;

        public TODOController(ILogger<TODOController> logger, ITODORepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpPost]
        public async Task<TodoDto> Post([FromBody] TodoDto data)
        {
            
            return data;
        }

    }
}
