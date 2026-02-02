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
    public class Cl_LN_Usuarios
    {
        private Cl_Interface_Usuarios obj_usuario = new Cl_Interface_Usuarios();
        public DataTable GetAllUsuarios()
        {
            return obj_usuario.GetUsuarios();
        }
        public void InsertarUsuario(string nombreUsuario, string contrasena, bool esAdmin)
        {
            obj_usuario.InsertarUsuario(nombreUsuario, contrasena, esAdmin);
        }
        public void ActualizarUsuario(int id, string nombreUsuario, string contrasena, bool esAdmin)
        {
            obj_usuario.ActualizarUsuario(id, nombreUsuario, contrasena, esAdmin);
        }
        public void EliminarUsuario(int id)
        {
            obj_usuario.EliminarUsuario(id);
        }
        public bool ValidarContrasena(string cedula, string contrasena)
        {
            string pass = obj_usuario.ObtenerContrasena(cedula);
            return pass == contrasena;
        }
        public Cl_Usuario ObtenerUsuario(string cedula)
        {
            DataTable dt = obj_usuario.GetUsuarioPorCedula(cedula);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Cl_Usuario(
                    Convert.ToInt32(row["id"]),
                    row["usuario"].ToString(),
                    Convert.ToBoolean(row["es_admin"])
                );
            }
            return null;
        }
        public DataTable BuscarUsuarios(string criterio)
        {
            return obj_usuario.BuscarUsuarios(criterio);
        }
    }
}
