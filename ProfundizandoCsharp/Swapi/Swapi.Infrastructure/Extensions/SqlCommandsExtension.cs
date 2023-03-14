using System.Data.SqlClient;
using System.Reflection;

namespace Swapi.Infrastructure.Extensions;


public static class SqlCommandsExtension
{
    #region AddDtoParameters
    /// <summary>
    /// Este metodo permite convertir un dto en un parametro sql
    /// </summary>
    /// <typeparam name="T">Tipo de objeto que se van a convertir</typeparam>
    /// <param name="cmd">SqlCommand al que se le van agregar los parametros</param>
    /// <param name="dto">Objeto cuyas propiedades van a ver convertidad a parametros</param>
    public static void AddDtoParameters<T>(this SqlCommand cmd, T dto) where T : class, new()
    {
        try
        {

            var properties = dto.GetType().GetProperties();

            foreach (var property in properties)
            {

                PropertyInfo propertyInfo = dto.GetType().GetProperty(property.Name);
                if (propertyInfo != null)
                {

                    string propertyName = propertyInfo.GetDisplayName();

                    cmd.Parameters.AddWithValue($"@{propertyName}", propertyInfo.GetValue(dto, null));
                }
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion
}

