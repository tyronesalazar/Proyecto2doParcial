using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Modelos
{
    public class Cl_Laboratorio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool Activo { get; set; }

        public Cl_Laboratorio(int id, string nombre, int capacidad, bool activo = true)
        {
            Id = id;
            Nombre = nombre;
            Capacidad = capacidad;
            Activo = activo;
        }

        public Cl_Laboratorio()
        {
            Id = 0;
            Nombre = "";
            Capacidad = 0;
            Activo = false;
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + ",Capacidad: " + this.Capacidad;
        }
    }
}
