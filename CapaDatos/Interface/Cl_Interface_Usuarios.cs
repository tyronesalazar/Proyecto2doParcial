using CapaDatos.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interface
{
    public class Cl_Interface_Usuarios
    {
        private Cl_ManagementSQL obj_sql = new Cl_ManagementSQL();

        public DataTable GetUsuarios()
        {
            string sql = "SELECT * FROM listar_usuarios();";
            return obj_sql.ExecuteSQLQuery(sql);
        }
        public void InsertarUsuario(string nombreUsuario, string contrasena, bool esAdmin)
        {
            try
            {
                string sql =
            "SELECT crear_usuario(" +
            "'" + nombreUsuario + "', " +
            "'" + contrasena + "', " +
            esAdmin +
            ");";
                obj_sql.ExecuteSQLQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public void EliminarUsuario(int idUsuario)
        {
            try
            {
                string sql =
            "SELECT eliminar_usuario(" +
            idUsuario +
            ");";
                obj_sql.ExecuteSQLQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public void ActualizarUsuario(int idUsuario, string nombreUsuario, string contrasena, bool esAdmin)
        {
            try
            {
                string sql =
            "SELECT modificar_usuario(" +
            idUsuario + ", " +
            "'" + nombreUsuario + "', " +
            "'" + contrasena + "', " +
            esAdmin +
            ");";
                obj_sql.ExecuteSQLQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public string ObtenerContrasena(string cedula)
        {
            string sql = "SELECT obtener_contrasena_usuario('" + cedula + "');";
            return obj_sql.ExecuteSQLScalar(sql); ;
        }
        public DataTable GetUsuarioPorCedula(string cedula)
        {
            string sql = "SELECT * FROM obtener_usuario_por_cedula('" + cedula + "');";
            return obj_sql.ExecuteSQLQuery(sql);
        }
        public DataTable BuscarUsuarios(string criterio)
        {
            string sql = "SELECT * FROM buscar_usuarios_por_cedula('" + criterio + "');";
            return obj_sql.ExecuteSQLQuery(sql);
        }
    }
}
