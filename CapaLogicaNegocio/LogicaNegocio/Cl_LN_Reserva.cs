using CapaDatos.Interface;
using CapaLogicaNegocio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.LogicaNegocio
{
    public class Cl_LN_Reserva
    {
        private Cl_Interface_Reservas obj_interface_reservas = new Cl_Interface_Reservas();

        public DataTable GetLista()
        {
            return obj_interface_reservas.GetReservas();
        }

        //public List<Cl_Reserva> GetReservasEnIntervalo(DateTime fechaInicio, DateTime fechaFin)
        //{
        //    return lista_reservas.Where(reserva => reserva.Fecha.Date >= fechaInicio.Date && reserva.Fecha.Date <= fechaFin.Date).ToList();
        //}

        public DataTable GetReservasPorLaboratorio(string labName)
        {
            return obj_interface_reservas.ObtenerReservasPorLab(labName);
        }

        //public double ObtenerHorasTotales(List<Cl_Reserva> reservas)
        //{
        //    double totalHoras = 0;
        //    foreach (var reserva in reservas)
        //    {
        //        totalHoras += (int)(reserva.HoraFin - reserva.HoraInicio).TotalHours;
        //    }
        //    return Math.Round(totalHoras, 2);
        //}

        public void CrearReserva(Cl_Reserva res)
        {
            obj_interface_reservas.InsertarReserva(res.Docente, res.Asignatura, res.LaboratorioId, res.Fecha, res.HoraInicio, res.HoraFin, res.CantEstudiantes);
        }
        public void ModificarReserva(Cl_Reserva res)
        {
            obj_interface_reservas.ModificarReserva(res.Id, res.Docente, res.Asignatura, res.LaboratorioId, res.Fecha, res.HoraInicio, res.HoraFin, res.CantEstudiantes, res.Estado);
        }
        public void EliminarReserva(int id)
        {
            obj_interface_reservas.EliminarReserva(id);
        }

        //// validar fechas y horas de reserva
        public bool ValidarDisponibilidad(Cl_Reserva nueva_reserva)
        {
            DataTable dt_reservas = obj_interface_reservas.GetReservas();

            foreach (DataRow reserva in dt_reservas.Rows)
            {
                if (reserva["id"].ToString().ToLower() == nueva_reserva.Id.ToString().ToLower()) return true;
                if (reserva["laboratorio_id"].ToString().ToLower() == nueva_reserva.LaboratorioId.ToString().ToLower() &&
                    reserva["fecha"].ToString().ToLower() == nueva_reserva.Fecha.Date.ToString().ToLower())
                {
                    if ((nueva_reserva.HoraInicio < TimeSpan.Parse(reserva["hora_inicio"].ToString())) && (nueva_reserva.HoraFin > TimeSpan.Parse(reserva["hora_final"].ToString())))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        // validar que el laboratorio tenga capacidad suficiente
        public bool ValidarCapacidad(Cl_Reserva nueva_reserva, int capacidad_laboratorio)
        {
            return nueva_reserva.CantEstudiantes <= capacidad_laboratorio;
        }

    }
}
