using Swapi.Core.Dtos;

namespace Swapi.Core.Interfaces
{
    public interface IStartshipRepository
    {
        Task<bool> SaveStartship(int id, StartshipDto dto);

        bool SaveStartshipHelper(int id, StartshipDto dto);
    }
}
