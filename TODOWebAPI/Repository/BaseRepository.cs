using Microsoft.Extensions.Options;
using TODOWebAPI.Domain.Entities;

namespace TODOWebAPI.Repository
{
    public abstract class BaseRepository
    {
        private AppConfiguration _appConfiguration { get; set; }
        public BaseRepository(IOptions<AppConfiguration> appConfiguration)
        {
            _appConfiguration = appConfiguration.Value;
            var n = _appConfiguration.Number;
        }
    }
}
