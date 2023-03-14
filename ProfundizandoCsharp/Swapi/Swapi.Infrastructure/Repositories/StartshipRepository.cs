using Microsoft.Extensions.Configuration;
using Swapi.Core.Dtos;
using Swapi.Core.Interfaces;
using Swapi.Infrastructure.Helpers;

namespace Swapi.Infrastructure.Repositories
{
    public class StartshipRepository : IStartshipRepository
    {
        private readonly IConfiguration _configuration;
        private readonly ILogService _logService;

        public StartshipRepository(IConfiguration configuration, ILogService logService)
        {
            _configuration = configuration;
            _logService = logService;
        }
        public Task<bool> SaveStartship(int id, StartshipDto dto)
        {
            throw new NotImplementedException();
        }

        public bool SaveStartshipHelper(int id, StartshipDto dto)
        {
            try
            {
                var parameters = new
                {
                    StartshipId = id,
                    dto.Name,
                    dto.Model,
                    dto.Manufacturer,
                    dto.Cost_in_credits,
                    dto.LMax_atmosphering_speed,
                    dto.Crew,
                    dto.Passengers,
                    dto.Cargo_capacity,
                    dto.Consumables
                };
                var res = GenericRepository<object>.Execute("PutStartship", "DefaultConnection", parameters, _configuration);
                return res;
            } 
            catch(Exception e)
            {
                _logService.SaveMessage($"Error al ejecutar el sp PutStartship, {e.Message}");
                return false;
            }
        }
    }
}
