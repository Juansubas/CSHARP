using Microsoft.Extensions.Configuration;
using Swapi.Core.Dtos;
using Swapi.Core.Enums;
using Swapi.Core.Interfaces;

namespace Swapi.Infrastructure.Services;

public class StartshipService : BaseService, IStartshipService
{
    private readonly IConfiguration _configuration;
    public StartshipService(IHttpClientFactory httpClient, ILogService logService, IConfiguration configuration) : base(httpClient, logService)
    {
        _configuration = configuration;
    }

    public async Task<T> RequestStartship<T>(int id)
    {
        return await this.SendAsync<T>(new ApiRequestDto()
        {
            ApiType = ApiType.GET,
            Url = string.Format(_configuration["Urls:Starship"] ?? "https://swapi.dev/api/starships/{0}", id),
            AccessToken = string.Empty
        });
    }
}
