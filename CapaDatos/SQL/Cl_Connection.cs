using Npgsql;
using System.Data;

namespace CapaDatos.SQL
{
    internal class Cl_Connection
    {
        private static string cadena_conexion =
                "Host=dpg-d5rov7ngi27c73909410-a.oregon-postgres.render.com;" +
                "Port=5432;" +
                "Username=poedatabase_user;" +
                "Password=2pnRwHrWzUB5AxXuhHJut4cVjpehqPip;" +
                "Database=poedatabase;" +
                "SSL Mode=Require;Trust Server Certificate=true;";


        private NpgsqlConnection connection_db = new NpgsqlConnection(cadena_conexion);

        internal NpgsqlConnection openConnection()
        {

            if (connection_db.State == ConnectionState.Closed)
            {
                try
                {
                    connection_db.Open();
                    Console.WriteLine("Conexion Abierta");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al abrir la conexion");
                    throw;
                }


            }
            return connection_db;
        }

        internal NpgsqlConnection closeConnection()
        {
            if (connection_db.State == ConnectionState.Open)
                connection_db.Close();
            Console.WriteLine("Conexion Cerrada");
            return connection_db;
        }
    }
}