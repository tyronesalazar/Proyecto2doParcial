using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.SQL
{
    internal class Cl_ManagementSQL
    {
        private Cl_Connection conn = new Cl_Connection();

        internal bool ExecuteSQLNonQuery(string sql)
        {
            try
            {
                using var comando = new NpgsqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conn.openConnection();
                int result = comando.ExecuteNonQuery();
                conn.closeConnection();

                return result > 0;
            }
            catch (Exception)
            {
                Console.WriteLine("Error executing SQL Non-Query.");
                conn.closeConnection();
                return false;
            }
        }
        internal DataTable ExecuteSQLQuery(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                using var comando = new NpgsqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conn.openConnection();
                using NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
                da.Fill(dt);
                conn.closeConnection();
            }
            catch (Exception)
            {
                conn.closeConnection();
            }
            return dt;
        }
    }
}
