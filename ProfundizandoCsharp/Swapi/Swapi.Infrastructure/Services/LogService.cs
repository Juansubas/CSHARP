using Swapi.Core.Interfaces;
using System.Globalization;

namespace Swapi.Infrastructure.Services;

public class LogService : ILogService
{
    public void SaveMessage(string message)
    {
        var path = $@"{Directory.GetParent(AppContext.BaseDirectory).FullName}\logErrores.txt";

        using StreamWriter writer = new(path, true);
        
        writer.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt", CultureInfo.InvariantCulture)}]::{message}");
    }
}
