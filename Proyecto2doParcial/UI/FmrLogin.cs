using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.UI
{
    public partial class FmrLogin : Form
    {
        public FmrLogin()
        {
            InitializeComponent();
            txtCedulaUsu.Enter += txtCedulaUsu_Enter;
            txtCedulaUsu.Leave += txtCedulaUsu_Leave;
            txtContraseñaUsu.Enter += txtContraseñaUsu_Enter;
            txtContraseñaUsu.Leave += txtContraseñaUsu_Leave;
        }

        private void txtBuscarLab_Enter(object sender, EventArgs e)
        {

        }

        //texto de sugerencia campo cédula
        private void txtCedulaUsu_Enter(object sender, EventArgs e)
        {
            if (txtCedulaUsu.ForeColor == Color.Gray)
            {
                txtCedulaUsu.Text = "";
                txtCedulaUsu.ForeColor = Color.Black;
            }
        }

        private void txtCedulaUsu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedulaUsu.Text))
            {
                txtCedulaUsu.Text = "Cedula...";
                txtCedulaUsu.ForeColor = Color.Gray;
            }
        }

        //texto de sugerencia campo contraseña
        private void txtContraseñaUsu_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaUsu.ForeColor == Color.Gray)
            {
                txtContraseñaUsu.Text = "";
                txtContraseñaUsu.ForeColor = Color.Black;
            }
        }

        private void txtContraseñaUsu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseñaUsu.Text))
            {
                txtContraseñaUsu.Text = "Buscar Usuario...";
                txtContraseñaUsu.ForeColor = Color.Gray;
            }
        }

    }
}
