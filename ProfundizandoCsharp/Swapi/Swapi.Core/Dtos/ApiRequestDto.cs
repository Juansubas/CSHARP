using Swapi.Core.Enums;

namespace Swapi.Core.Dtos
{
    public class ApiRequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
