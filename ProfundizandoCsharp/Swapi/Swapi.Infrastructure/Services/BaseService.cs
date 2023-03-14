using Newtonsoft.Json;
using Swapi.Core.Dtos;
using Swapi.Core.Enums;
using Swapi.Core.Interfaces;
using System.Net.Http.Headers;
using System.Text;

namespace Swapi.Infrastructure.Services
{
    public class BaseService : IBaseService
    {
        public IHttpClientFactory httpClient { get; set; }
        private readonly ILogService _logService;
        public BaseService(IHttpClientFactory httpClient, ILogService logService) 
        {
            this.httpClient = httpClient;
            _logService = logService;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public async Task<T> SendAsync<T>(ApiRequestDto apiRequest)
        {
            try
            {
                var cliente = httpClient.CreateClient("SWAPI");

                var mensaje = new HttpRequestMessage();
                
                mensaje.Headers.Add("Accept", "application/json");

                cliente.BaseAddress = new Uri(apiRequest.Url);

                if(apiRequest.Data != null)
                {
                    mensaje.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data), Encoding.UTF8,
                        "application/json");
                }

                if(!string.IsNullOrEmpty(apiRequest.AccessToken))
                {
                    cliente.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", apiRequest.AccessToken);
                }

                HttpResponseMessage apiResponse = null;
                mensaje.Method = apiRequest.ApiType switch
                {
                    ApiType.POST => HttpMethod.Post,
                    ApiType.PUT => HttpMethod.Put,
                    ApiType.DELETE => HttpMethod.Delete,
                    _ => HttpMethod.Get
                };

                apiResponse = await cliente.SendAsync(mensaje);
                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponseDto = JsonConvert.DeserializeObject<T>(apiContent);

                return apiResponseDto;

            }
            catch (Exception e)
            {
                _logService.SaveMessage(e.Message);
                throw;
            }
        }
    }
}
