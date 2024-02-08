using Microsoft.Extensions.Options;
using TODOWebAPI.Domain.Entities;
using TODOWebAPI.Domain.Interfaces;

namespace TODOWebAPI.Repository
{
    public class TODORepository : BaseRepository, ITODORepository
    {
        public TODORepository(IOptions<AppConfiguration> appConfiguration) : base(appConfiguration)
        {
        }
    }
}
