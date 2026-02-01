using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Modelos
{
    public class Cl_DetallesReportes
    {
        public string LabMasUsado { get; set; }
        public long TotalReservas { get; set; }
        public decimal TotalHoras { get; set; }
        public Cl_DetallesReportes()
        {
            LabMasUsado = String.Empty;
            TotalReservas = 0;
            TotalHoras = 0;
        }
        public Cl_DetallesReportes(string labMasUsado, long totalReservas,
                           decimal totalHoras)
        {
            LabMasUsado = labMasUsado;
            TotalReservas = totalReservas;
            TotalHoras = totalHoras;
        }
    }
}
