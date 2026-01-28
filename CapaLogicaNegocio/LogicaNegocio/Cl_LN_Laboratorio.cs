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
        //public List<Cl_Laboratorio> lista_laboratorios = new List<Cl_Laboratorio>();

        //// Obtener siguiente ID
        //public int GetNextId()
        //{
        //    if (lista_laboratorios.Count == 0)
        //        return 1;
        //    return lista_laboratorios[lista_laboratorios.Count - 1].Id + 1;
        //}

        // Retorna índice por ID
        //public int GetIndiceLista(int id)
        //{
        //    for (int i = 0; i < lista_laboratorios.Count; i++)
        //    {
        //        if (lista_laboratorios[i].Id == id)
        //            return i;
        //    }
        //    return -1;
        //}
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

        //public Cl_Laboratorio ObtenerLaboratorioPorId(int id)
        //{
        //    return lista_laboratorios.FirstOrDefault(lab => lab.Id == id);
        //}
        //public List<Cl_Laboratorio> ObtenerLaboratorioPorNombre(string nombre)
        //{
        //    return lista_laboratorios
        //        .Where(lab => lab.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
        //        .ToList();
        //}
        //public List<Cl_Laboratorio> ObtenerLaboratoriosPorCapacidad(int capacidadMinima)
        //{
        //    return lista_laboratorios
        //        .Where(lab => lab.Capacidad >= capacidadMinima)
        //        .ToList();
        //}
        ////obtener laboratorios activos
        //public List<Cl_Laboratorio> ObtenerLaboratoriosActivos()
        //{
        //    List<Cl_Laboratorio> laboratoriosActivos = new List<Cl_Laboratorio>();
        //    foreach (var lab in lista_laboratorios)
        //    {
        //        if (lab.Activo)
        //        {
        //            laboratoriosActivos.Add(lab);
        //        }
        //    }
        //    return laboratoriosActivos;
        //}
    }
}
