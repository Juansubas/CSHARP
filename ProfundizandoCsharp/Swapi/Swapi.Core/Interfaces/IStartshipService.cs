namespace Swapi.Core.Interfaces
{
    public interface IStartshipService
    {
        Task<T> RequestStartship<T>(int id);
    }
}
