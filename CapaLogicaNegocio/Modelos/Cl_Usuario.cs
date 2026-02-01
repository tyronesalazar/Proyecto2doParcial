using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interface;


namespace CapaLogicaNegocio.Modelos
{
    public class Cl_Usuario
    {
        public int CuentaId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public Cl_Usuario()
        {
            CuentaId = 0;
            NombreUsuario = string.Empty;
            Contrasena = string.Empty;
        }
        public Cl_Usuario(int cuentaId, string nombreUsuario, string contrasena)
        {
            CuentaId = cuentaId;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
        }
    }
}
