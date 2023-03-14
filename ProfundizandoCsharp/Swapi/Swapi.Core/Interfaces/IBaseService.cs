using Swapi.Core.Dtos;

namespace Swapi.Core.Interfaces
{
    public interface IBaseService : IDisposable
    {
        Task<T> SendAsync<T>(ApiRequestDto apiRequest);
    }
}
