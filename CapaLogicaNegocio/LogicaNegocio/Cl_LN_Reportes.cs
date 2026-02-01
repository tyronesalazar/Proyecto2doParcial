using CapaLogicaNegocio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.LogicaNegocio
{
    public class Cl_LN_Reportes
    {

        public Cl_DetallesReportes GenerarReporte(DataTable reservas)
        {
            Cl_DetallesReportes reporte = new Cl_DetallesReportes();

            decimal horasTotales = 0;
            long totalReservas = 0;
            decimal maxHoras = 0;
            string laboratorioMasUsado = string.Empty;

            foreach (DataRow reserva in reservas.Rows)
            {
                decimal horas = reserva.Field<decimal>("horas_usadas");
                long reservasTotales = reserva.Field<long>("cantidad_reservas");
                string laboratorio = reserva.Field<string>("laboratorio");

                horasTotales += horas;
                totalReservas += reservasTotales;

                if (horas > maxHoras)
                {
                    maxHoras = horas;
                    laboratorioMasUsado = laboratorio;
                }
            }
            reporte.TotalHoras = Math.Round(horasTotales, 2);
            reporte.TotalReservas = totalReservas;
            reporte.LabMasUsado = laboratorioMasUsado;
            return reporte;
        }
    }
}
