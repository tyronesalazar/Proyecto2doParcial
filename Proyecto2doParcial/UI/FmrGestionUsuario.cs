using CapaLogicaNegocio.LogicaNegocio;
using CapaLogicaNegocio.Modelos;
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
        Cl_LN_Usuarios ln_usuarios = new();
        Cl_Usuario usuario;
        public FmrGestionUsuario()
        {
            InitializeComponent();
            this.Shown += FmrGestionUsuario_Shown;
            txtBuscarUsuario.Enter += txtBuscarUsuario_Enter;
            txtBuscarUsuario.Leave += txtBuscarUsuario_Leave;
            cargarUsuariosGrid();
            toggleControles(false);
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
        private void cargarUsuariosGrid()
        {
            dgvGestionUsuarios.AutoGenerateColumns = false;
            dgvGestionUsuarios.DataSource = null;
            dgvGestionUsuarios.DataSource = ln_usuarios.GetAllUsuarios();
            dgvGestionUsuarios.ClearSelection();

        }

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
            btnEliminarUsuario.Enabled = false;
        }
        private void toggleControles(bool valor)
        {
            txtUsuario.Enabled = valor;
            txtContraseña.Enabled = valor;
            chkEsAdmin.Enabled = valor;
        }
        private bool ValidarCampos()
        {
            // Validar Usuario (cédula)
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el número de cédula.");
                txtUsuario.Focus();
                return false;
            }

            if (!txtUsuario.Text.All(char.IsDigit))
            {
                MessageBox.Show("La cédula solo debe contener números.");
                txtUsuario.Focus();
                return false;
            }

            if (txtUsuario.Text.Length != 10)
            {
                MessageBox.Show("La cédula debe tener exactamente 10 dígitos.");
                txtUsuario.Focus();
                return false;
            }

            // Validar Contraseña
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese una contraseña.");
                txtContraseña.Focus();
                return false;
            }

            if (txtContraseña.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                txtContraseña.Focus();
                return false;
            }

            return true;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            // Limitar a 10 dígitos
            if (char.IsDigit(e.KeyChar) && txtUsuario.Text.Length >= 10)
            {
                e.Handled = true;
            }

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no permitir espacios
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            //limitar longitud de contraseña a 16 caracteres
            if (txtContraseña.Text.Length >= 16 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            toggleControles(false);
            if (ValidarCampos())
            {
                usuario.NombreUsuario = txtUsuario.Text;
                usuario.Contrasena = txtContraseña.Text;
                usuario.EsAdmin = chkEsAdmin.Checked;

                if (usuario.CuentaId >= 0)
                {
                    ln_usuarios.ActualizarUsuario(usuario.CuentaId, txtUsuario.Text, txtContraseña.Text, chkEsAdmin.Checked);
                    MessageBox.Show("Usuario actualizado con éxito.");
                    limpiar_controles();
                    cargarUsuariosGrid();
                    return;
                }

                ln_usuarios.InsertarUsuario(txtUsuario.Text, txtContraseña.Text, chkEsAdmin.Checked);
                MessageBox.Show("Usuario registrado con éxito.");
                limpiar_controles();
                cargarUsuariosGrid();
            }
        }

        private void dgvGestionUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = dgvGestionUsuarios.Rows[e.RowIndex];
                    int id = Convert.ToInt32(row.Cells["dgvId"].Value);
                    string cedula = row.Cells["dgvUsuario"].Value.ToString();
                    string contraseña = row.Cells["dgvContrasena"].Value.ToString();
                    bool esAdmin = Convert.ToBoolean(row.Cells["dgvEsAdmin"].Value);
                    txtUsuario.Text = cedula;
                    txtContraseña.Text = contraseña;
                    chkEsAdmin.Checked = esAdmin;
                    usuario = new(id, cedula, contraseña, esAdmin);
                    btnEliminarUsuario.Enabled = true;
                    toggleControles(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el usuario: " + ex.Message);
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            usuario = new();
            limpiar_controles();
            toggleControles(true);
            Console.WriteLine(usuario.ToString());
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            DataTable usuariosBuscados = ln_usuarios.BuscarUsuarios(txtBuscarUsuario.Text);
            dgvGestionUsuarios.DataSource = null;
            dgvGestionUsuarios.DataSource = usuariosBuscados;

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                ln_usuarios.EliminarUsuario(usuario.CuentaId);
                MessageBox.Show("Usuario eliminado con éxito.");
                limpiar_controles();
                cargarUsuariosGrid();
            }
        }
    }
}
