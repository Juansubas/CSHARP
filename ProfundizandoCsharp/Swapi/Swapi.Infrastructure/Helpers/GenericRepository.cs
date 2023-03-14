using Microsoft.Extensions.Configuration;
using Swapi.Infrastructure.Extensions;
using System.Data;
using System.Data.SqlClient;

namespace Swapi.Infrastructure.Helpers;

public class GenericRepository<T> where T : class, new()
{
    public static bool Execute(string spName, string strConection, T parameters, IConfiguration configuration)
    {
        try
        {
            using (var conn = new SqlConnection(configuration.GetConnectionString(strConection)))
            {
                try
                {
                    var cmd = new SqlCommand(spName, conn)
                    { CommandType = CommandType.StoredProcedure };
                    if (parameters != null)
                    {
                        cmd.AddDtoParameters(parameters);
                    }

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception e)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public static DataSet GetDataSet(string spName, string strConection, T parameters, IConfiguration configuration)
    {
        var dtr = new DataSet();
        try
        {
            using (var conn = new SqlConnection(configuration.GetConnectionString(strConection)))
            {
                try
                {
                    var cmd = new SqlCommand(spName, conn)
                    { CommandType = CommandType.StoredProcedure };
                    if (parameters != null)
                    {
                        cmd.AddDtoParameters(parameters);
                    }

                    conn.Open();
                    var dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dtr);
                    return dtr;
                }
                catch (Exception e)
                {
                    conn.Close();
                    Console.WriteLine(e);
                    throw;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
