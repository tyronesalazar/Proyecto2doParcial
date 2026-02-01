using CapaDatos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.LogicaNegocio
{
    public class Cl_LN_Usuarios
    {
        private Cl_Interface_Usuarios obj_usuario = new Cl_Interface_Usuarios();
        public DataTable GetAllUsuarios()
        {
            return obj_usuario.GetUsuarios();
        }
    }
}
