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

        public DataTable GetReservasEnIntervalo(DateTime fechaInicio, DateTime fechaFin)
        {
            return obj_interface_reservas.ObtenerReservasEnIntervalo(fechaInicio, fechaFin);
        }
        public DataTable GetReservaPorId(int id)
        {
            return obj_interface_reservas.ObtenerReservaPorId(id);
        }
        public DataTable GetReservasPorLaboratorio(string labName)
        {
            return obj_interface_reservas.ObtenerReservasPorLab(labName);
        }

        public double ObtenerHorasTotales(DataTable reservas)
        {
            double totalHoras = 0;
            foreach (DataRow reserva in reservas.Rows)
            {
                TimeSpan horaInicio = TimeSpan.Parse(reserva["hora_inicio"].ToString());
                TimeSpan horaFin = TimeSpan.Parse(reserva["hora_fin"].ToString());
                totalHoras += (int)(horaInicio - horaFin).TotalHours;
            }
            return Math.Round(totalHoras, 2);
        }

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
            DataTable dt_reservas = obj_interface_reservas.ObtenerReservasPorFecha(nueva_reserva.Fecha);

            if (dt_reservas.Rows.Count == 0)
            {
                return true;
            }

            foreach (DataRow reserva in dt_reservas.Rows)
            {
                if (reserva.Field<int>("id") == nueva_reserva.Id) continue;
                if (reserva.Field<int>("laboratorio_id") == nueva_reserva.LaboratorioId)
                {
                    if ((nueva_reserva.HoraInicio < reserva.Field<TimeOnly>("hora_inicio").ToTimeSpan()) && (nueva_reserva.HoraFin > reserva.Field<TimeOnly>("hora_fin").ToTimeSpan()))
                    {
                        return false;
                    }
                    else if ((nueva_reserva.HoraInicio >= reserva.Field<TimeOnly>("hora_inicio").ToTimeSpan()) && (nueva_reserva.HoraInicio < reserva.Field<TimeOnly>("hora_fin").ToTimeSpan()))
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
