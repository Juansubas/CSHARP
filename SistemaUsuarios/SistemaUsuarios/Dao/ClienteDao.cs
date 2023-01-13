using SistemaUsuarios.Models;
using System.Data.SqlClient;

namespace SistemaUsuarios.Dao
{
    class ClienteDao
    {
        //String con la configuración para la conexión
        private string connectionString = 
            "Data Source=LAPTOP-TL4C59QQ;Initial Catalog=CSHARP;Integrated Security=True";

        public List<Cliente> ConsultarClientes()
        {
            String query = "Select id, nombre, apellido, telefono, tarjeta from clientes";

            List<Cliente> list = new List<Cliente>();

            using(var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);

                connection.Open();
                
                // Nos lee la información de la consulta
                SqlDataReader reader = command.ExecuteReader();

                // Con esto recorremos dicha información
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = reader.GetInt32(0);
                    cliente.Nombre = reader.GetString(1);
                    cliente.Apellido = reader.GetString(2);
                    cliente.Telefono = reader.GetString(3);
                    cliente.TarjetaDeCredito = reader.GetString(4);

                    list.Add(cliente);
                }

                connection.Close();
            }

            return list;
        }

        public void AñadirCliente(Cliente cliente)
        {   // Consulta Sql
            String query = "INSERT INTO clientes(nombre, apellido, telefono, tarjeta)" +
                "values(@nombre, @apellido, @telefono, @tarjeta)";

            // Mediante Using creamos un espacio donde agregamos los nameSpaces
            // Podemos especificar un espacio donde el objeto conexión desaparece
            // Cuando termina el using,o cualquier otro objeto.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {   
                //SqlCommand -> sirve para enviar consultas.
                SqlCommand command = new SqlCommand(query, connection);

                //Preparamos lo que vamos a enviar

                command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@tarjeta", cliente.TarjetaDeCredito);

                //Esto haga de cuenta que deja preparado lo que se hará en la BD
                //Falta es conectarse y hacerlo
                //Abriendo la conexión para cargar lo anterior
                connection.Open();

                //Para ejecutar el Insert
                command.ExecuteNonQuery();

                //Cerrando la conexión
                connection.Close();
            }
            
        }

        public void ActualizarCliente(Cliente cliente, int Id)
        {
            String query = "update clientes set nombre = @nombre, apellido = @apellido, " +
                "telefono = @telefono, tarjeta = @tarjeta " + "where id=@id";

            using(var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@tarjeta", cliente.TarjetaDeCredito);
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void EliminarCliente(int Id)
        {
            String query = "delete from clientes where id=@id";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);

                connection.Open();

                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
