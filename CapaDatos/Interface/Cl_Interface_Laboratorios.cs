using CapaDatos.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interface
{
    public class Cl_Interface_Laboratorios
    {
        private Cl_ManagementSQL obj_sql = new Cl_ManagementSQL();

        public DataTable GetLaboratorios()
        {
            string sql = "SELECT * FROM listar_laboratorios();";
            return obj_sql.ExecuteSQLQuery(sql);
        }

        public void InsertarLaboratorio(string nombre, int capacidad, bool activo)
        {
            string sql = "SELECT crear_laboratorio('" + nombre + "'," + capacidad + "," + activo + ")";
            obj_sql.ExecuteSQLNonQuery(sql);
        }

        public void ModificarLaboratorio(int id, string nombre, int capacidad, bool activo)
        {
            string sql = "SELECT actualizar_laboratorio(" + id + ",'" + nombre + "'," + capacidad + "," + activo + ")";
            obj_sql.ExecuteSQLNonQuery(sql);
        }

        public void EliminarLaboratorio(int id)
        {
            string sql = "SELECT eliminar_laboratorio(" + id + ")";
            obj_sql.ExecuteSQLNonQuery(sql);
        }

        public DataTable ObtenerLaboratorioPorId(int id)
        {
            string sql = "SELECT * FROM laboratorios l WHERE l.id =" + id;
            return obj_sql.ExecuteSQLQuery(sql);
        }

        public DataTable ObtenerLaboratorioPorNombre(string nombre)
        {
            string sql = "SELECT * FROM laboratorios l WHERE l.nombre ILIKE '%' || '" + nombre + "' || '%';";
            return obj_sql.ExecuteSQLQuery(sql);
        }

        public DataTable ObtenerLaboratoriosActivos()
        {
            string sql = "SELECT * FROM laboratorios l WHERE l.activo = true;";
            return obj_sql.ExecuteSQLQuery(sql);
        }
    }
}
