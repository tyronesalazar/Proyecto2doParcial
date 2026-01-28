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

namespace APPreservaLabUI.UI
{
    public partial class FmrLaboratorios : Form
    {
        private bool is_lab_nuevo = false;
        private Cl_LN_Laboratorio ln_laboratorio;
        bool cargandoDatos = false;
        public FmrLaboratorios(Cl_LN_Laboratorio ln)
        {
            ln_laboratorio = ln;

            InitializeComponent();
            this.Shown += FmrLaboratorios_Shown;
            txtBuscarLab.Enter += txtBuscarLab_Enter;
            txtBuscarLab.Leave += txtBuscarLab_Leave;

            CargarLaboratoriosGrid();

            btnGrabarLab.Enabled = false;
            btnEliminarLab.Enabled = false;
            btnNuevoLab.Enabled = true;
            HabilitarCampos(false);
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

        //Redondeo en cuestión
        private void FmrLaboratorios_Shown(object sender, EventArgs e)
        {
            RedondearPanel(panelConten, 60);
            RedondearPanel(panelNameLab, 30);
            RedondearPanel(panelCapLab, 30);
            RedondearPanel(panelBuscarLab, 30);
            RedondearPanel(panelTabla, 60);

        }
        //Busqueda texto de sugerencia
        private void txtBuscarLab_Enter(object sender, EventArgs e)
        {
            if (txtBuscarLab.ForeColor == Color.Gray)
            {
                txtBuscarLab.Text = "";
                txtBuscarLab.ForeColor = Color.Black;
            }
        }

        private void txtBuscarLab_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarLab.Text))
            {
                txtBuscarLab.Text = "Buscar laboratorio...";
                txtBuscarLab.ForeColor = Color.Gray;
            }
        }

        private void limpiar_controles()
        {
            txtNombreLab.Text = string.Empty;
            txtCapacidadLab.Text = string.Empty;
            txtID.Text = string.Empty;
            chkActivo.Checked = false;
        }

        private void btnNuevoLab_Click(object sender, EventArgs e)
        {
            dgvGestionLab.ClearSelection();
            cargandoDatos = true;
            is_lab_nuevo = true;

            HabilitarCampos(true);
            limpiar_controles();
            btnGrabarLab.Enabled = true;
            btnEliminarLab.Enabled = false;
            btnNuevoLab.Enabled = false;

            txtNombreLab.Focus();
        }


        private void btnGrabarLab_Click(object sender, EventArgs e)
        {

            try
            {
                if (!ValidarCampos())
                    return;
                cargandoDatos = true;
                Cl_Laboratorio lab = new Cl_Laboratorio();

                if (is_lab_nuevo)
                {
                    lab.Nombre = txtNombreLab.Text;
                    lab.Capacidad = int.Parse(txtCapacidadLab.Text);
                    lab.Activo = chkActivo.Checked;

                    try
                    {
                        btnGrabarLab.Enabled = false;
                        ln_laboratorio.CrearLaboratorio(lab);
                        btnGrabarLab.Enabled = true;
                        MessageBox.Show("Laboratorio creado exitosamente.");
                    }
                    catch (Exception)
                    {
                        btnGrabarLab.Enabled = true;
                        MessageBox.Show("Error al crear el laboratorio.");
                    }
                }
                else
                {
                    lab.Id = int.Parse(txtID.Text);
                    lab.Nombre = txtNombreLab.Text;
                    lab.Capacidad = int.Parse(txtCapacidadLab.Text);
                    lab.Activo = chkActivo.Checked;

                    ln_laboratorio.ModificarLaboratorio(lab);
                    MessageBox.Show("Laboratorio modificado correctamente.");
                }

                is_lab_nuevo = false;

                btnGrabarLab.Enabled = false;
                btnEliminarLab.Enabled = false;
                btnNuevoLab.Enabled = true;
                limpiar_controles();
                HabilitarCampos(false);
                CargarLaboratoriosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cargandoDatos = false;
            }
        }

        private void btnEliminarLab_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);

                var confirm = MessageBox.Show(
                    "¿Está seguro de eliminar este laboratorio?",
                    "Confirmar", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    ln_laboratorio.EliminarLaboratorio(id);
                    MessageBox.Show("Laboratorio eliminado.");

                    limpiar_controles();
                    btnGrabarLab.Enabled = false;
                    btnEliminarLab.Enabled = false;
                    btnNuevoLab.Enabled = true;
                    CargarLaboratoriosGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarLaboratoriosGrid()
        {
            dgvGestionLab.AutoGenerateColumns = false;
            dgvGestionLab.DataSource = null;
            dgvGestionLab.DataSource = ln_laboratorio.GetLista();
            dgvGestionLab.ClearSelection();
        }

        private void dgvGestionLab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    cargandoDatos = true;
                    is_lab_nuevo = false;

                    DataGridViewRow fila = dgvGestionLab.Rows[e.RowIndex];

                    txtID.Text = fila.Cells["dgvID"].Value?.ToString() ?? "";
                    txtNombreLab.Text = fila.Cells["nomLab"].Value?.ToString() ?? "";
                    txtCapacidadLab.Text = fila.Cells["capacidadLab"].Value?.ToString() ?? "";

                    // Estado (checkbox)
                    object estadoValor = fila.Cells["estadoLab"].Value;
                    chkActivo.Checked = (estadoValor != null && Convert.ToBoolean(estadoValor));

                    HabilitarCampos(true);

                    // Control de botones
                    btnNuevoLab.Enabled = true;
                    btnEliminarLab.Enabled = true;
                    btnGrabarLab.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al seleccionar el laboratorio:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                cargandoDatos = false;
            }
        }

        private void txtNombreLab_TextChanged(object sender, EventArgs e)
        {
            if (!is_lab_nuevo && !cargandoDatos)
                btnGrabarLab.Enabled = true;
        }

        private void txtCapacidadLab_TextChanged(object sender, EventArgs e)
        {
            if (!is_lab_nuevo && !cargandoDatos)
                btnGrabarLab.Enabled = true;
        }

        private void chkActivo_TextChanged(object sender, EventArgs e)
        {

        }
        private void HabilitarCampos(bool estado)
        {
            txtNombreLab.Enabled = estado;
            txtCapacidadLab.Enabled = estado;
            chkActivo.Enabled = estado;
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (!is_lab_nuevo && !cargandoDatos)
                btnGrabarLab.Enabled = true;
        }

        private void txtCapacidadLab_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la tecla
                return;
            }

            // Limitar a 3 dígitos
            if (char.IsDigit(e.KeyChar) && txtCapacidadLab.Text.Length >= 3)
            {
                e.Handled = true; // Cancela la tecla
            }
        }

        private void txtNombreLab_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y numeros
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela la tecla
            }
        }
        private bool ValidarCampos()
        {
            // Validar nombre
            if (string.IsNullOrWhiteSpace(txtNombreLab.Text))
            {
                MessageBox.Show("Ingrese un nombre para el laboratorio.");
                txtNombreLab.Focus();
                return false;
            }

            // Nombre mínimo 3 letras
            if (txtNombreLab.Text.Length < 3)
            {
                MessageBox.Show("El nombre debe tener al menos 3 caracteres.");
                txtNombreLab.Focus();
                return false;
            }

            // Validar capacidad
            if (string.IsNullOrWhiteSpace(txtCapacidadLab.Text))
            {
                MessageBox.Show("Ingrese la capacidad del laboratorio.");
                txtCapacidadLab.Focus();
                return false;
            }

            if (!int.TryParse(txtCapacidadLab.Text, out int capacidad))
            {
                MessageBox.Show("La capacidad debe ser un número válido.");
                txtCapacidadLab.Focus();
                return false;
            }

            if (capacidad <= 0)
            {
                MessageBox.Show("La capacidad debe ser mayor que 0.");
                txtCapacidadLab.Focus();
                return false;
            }

            return true;
        }

        private void btnBuscarLab_Click(object sender, EventArgs e)
        {
            dgvGestionLab.AutoGenerateColumns = false;
            dgvGestionLab.DataSource = null;
            //dgvGestionLab.DataSource = ln_laboratorio.ObtenerLaboratorioPorNombre(txtBuscarLab.Text);
        }
    }
}
