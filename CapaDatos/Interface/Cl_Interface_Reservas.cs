using CapaDatos.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interface
{
    public class Cl_Interface_Reservas
    {
        private Cl_ManagementSQL obj_sql = new Cl_ManagementSQL();

        public DataTable GetReservas()
        {
            string sql = "SELECT * FROM listar_reservas();";
            return obj_sql.ExecuteSQLQuery(sql);
        }
        public void InsertarReserva(string docente, string asignatura, int labId, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, int cantEstudiantes)
        {
            try
            {
                string sql =
            "SELECT crear_reserva(" +
            "'" + docente + "', " +
            "'" + asignatura + "', " +
            labId + ", " +
            "'" + fecha.ToString("yyyy-MM-dd") + "', " +
            "'" + horaInicio + "', " +
            "'" + horaFin + "', " +
            cantEstudiantes +
            ");";

                obj_sql.ExecuteSQLQuery(sql);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "hola");
                throw;
            }
        }
        public bool ModificarReserva(
            int id,
            string docente,
            string asignatura,
            int labId,
            DateTime fecha,
            TimeSpan horaInicio,
            TimeSpan horaFin,
            int cantEstudiantes,
            string estado
            )
        {
            string sql =
                "SELECT actualizar_reserva(" +
                id + ", " +
                "'" + docente + "', " +
                "'" + asignatura + "', " +
                labId + ", " +
                "'" + fecha.ToString("yyyy-MM-dd") + "', " +
                "'" + horaInicio + "', " +
                "'" + horaFin + "', " +
                "'" + cantEstudiantes + "', " +
                "'" + estado + "'" +
                ");";

            return obj_sql.ExecuteSQLNonQuery(sql);
        }

        public bool EliminarReserva(int id)
        {
            string sql =
                "SELECT eliminar_reserva(" +
                id +
                ");";
            return obj_sql.ExecuteSQLNonQuery(sql);
        }

        public DataTable ObtenerReservasPorLab(string labName)
        {
            string sql = "SELECT * FROM obtener_reservas_por_nombre_laboratorio('" + labName + "');";
            return obj_sql.ExecuteSQLQuery(sql);
        }
        public DataTable ObtenerReservaPorId(int id)
        {
            string sql = "SELECT * FROM obtener_reserva_por_id(" + id + ");";
            return obj_sql.ExecuteSQLQuery(sql);
        }
        public DataTable ObtenerReservasPorFecha(DateTime fecha)
        {
            string sql = $"SELECT * FROM obtener_reservas_por_fecha('{fecha:yyyy-MM-dd}')";
            return obj_sql.ExecuteSQLQuery(sql);
        }
        public DataTable ObtenerReservasEnIntervalo(DateTime fechaInicio, DateTime fechaFin)
        {
            string sql = "SELECT * FROM reporte_uso_laboratorios_por_intervalo('" + fechaInicio.ToString("yyyy-MM-dd") + "', '" + fechaFin.ToString("yyyy-MM-dd") + "');";
            return obj_sql.ExecuteSQLQuery(sql);
        }
    }
}
