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
    public class Cl_LN_Laboratorio
    {
        private Cl_Interface_Laboratorios obj_laboratorio = new();

        // Obtener lista completa
        public DataTable GetLista()
        {
            return obj_laboratorio.GetLaboratorios();
        }

        // Crear laboratorio
        public void CrearLaboratorio(Cl_Laboratorio lab)
        {
            obj_laboratorio.InsertarLaboratorio(lab.Nombre, lab.Capacidad, lab.Activo);
        }

        //// Modificar laboratorio
        public void ModificarLaboratorio(Cl_Laboratorio lab)
        {
            obj_laboratorio.ModificarLaboratorio(lab.Id, lab.Nombre, lab.Capacidad, lab.Activo);

        }

        // Eliminar laboratorio
        public void EliminarLaboratorio(int id)
        {
            obj_laboratorio.EliminarLaboratorio(id);
        }

        // Obtener laboratorio por Id
        public Cl_Laboratorio ObtenerLaboratorioPorId(int id)
        {
            Cl_Laboratorio lab = new();
            DataTable tabla = obj_laboratorio.ObtenerLaboratorioPorId(id);
            foreach (DataRow row in tabla.Rows)
            {
                lab.Id = int.Parse(row["id"].ToString());
                lab.Nombre = row["nombre"].ToString();
                lab.Capacidad = int.Parse(row["capacidad"].ToString());
                lab.Activo = bool.Parse(row["activo"].ToString());
            }
            return lab;
        }
        public DataTable ObtenerLaboratorioPorNombre(string nombre)
        {
            return obj_laboratorio.ObtenerLaboratorioPorNombre(nombre);
        }
        //public List<Cl_Laboratorio> ObtenerLaboratoriosPorCapacidad(int capacidadMinima)
        //{
        //    return lista_laboratorios
        //        .Where(lab => lab.Capacidad >= capacidadMinima)
        //        .ToList();
        //}
        //obtener laboratorios activos
        public DataTable ObtenerLaboratoriosActivos()
        {
            return obj_laboratorio.ObtenerLaboratoriosActivos();
        }
    }
}
