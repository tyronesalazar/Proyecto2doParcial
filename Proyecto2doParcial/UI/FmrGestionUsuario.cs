using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.UI
{
    public partial class FmrGestionUsuario : Form
    {
        public FmrGestionUsuario()
        {
            InitializeComponent();
            this.Shown += FmrGestionUsuario_Shown;
            txtBuscarUsuario.Enter += txtBuscarUsuario_Enter;
            txtBuscarUsuario.Leave += txtBuscarUsuario_Leave;
        }

        //Estética de paneles
        private void RedondearPanel(Panel panel, int radius = 60)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }

        private void FmrGestionUsuario_Shown(object sender, EventArgs e)
        {
            RedondearPanel(panelConten, 60);
            RedondearPanel(panelCampoUsuario, 30);
            RedondearPanel(panelCampoContraseña, 30);
            RedondearPanel(panelBuscarUsuario, 30);
            RedondearPanel(panelTabla, 60);

        }

        //Busqueda texto de sugerencia

        private void txtBuscarUsuario_Enter(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.ForeColor == Color.Gray)
            {
                txtBuscarUsuario.Text = "";
                txtBuscarUsuario.ForeColor = Color.Black;
            }
        }

        private void txtBuscarUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarUsuario.Text))
            {
                txtBuscarUsuario.Text = "Buscar Usuario...";
                txtBuscarUsuario.ForeColor = Color.Gray;
            }
        }

        private void limpiar_controles()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
        }


    }
}
