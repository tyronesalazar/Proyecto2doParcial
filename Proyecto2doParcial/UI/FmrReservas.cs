using CapaLogicaNegocio.LogicaNegocio;
using CapaLogicaNegocio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APPreservaLabUI.UI
{
    public partial class FmrReservas : Form
    {
        private Cl_LN_Reserva ln_reserva;
        private Cl_LN_Laboratorio ln_laboratorio;
        private bool is_reserva_nueva = false;
        public FmrReservas(Cl_LN_Laboratorio ln_lab, Cl_LN_Reserva ln_res)
        {
            ln_reserva = ln_res;
            ln_laboratorio = ln_lab;
            InitializeComponent();
            this.Shown += FmrReservas_Shown;
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
        private void FmrReservas_Shown(object sender, EventArgs e)
        {
            RedondearPanel(panelNueva, 60);
            RedondearPanel(panelTabla, 30);
            RedondearPanel(panel1, 30);
        }

        private void CargarLaboratorios()
        {
            cmbLaboratorio.Items.Clear();
            //var laboratorios = ln_laboratorio.ObtenerLaboratoriosActivos();
            //foreach (var lab in laboratorios)
            //{
            //    cmbLaboratorio.Items.Add(lab.Nombre);
            //}
        }
        private void HabilitarCampos(bool estado)
        {
            cmbDocente.Enabled = estado;
            cmbAsignatura.Enabled = estado;
            cmbLaboratorio.Enabled = estado;
            dtpFecha.Enabled = estado;
            dtpInicio.Enabled = estado;
            dtpFinal.Enabled = estado;
            txtCantResv.Enabled = estado;

        }

        private void limpiar_controles()
        {
            cmbDocente.SelectedIndex = -1;
            cmbAsignatura.SelectedIndex = -1;
            cmbLaboratorio.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            dtpInicio.Value = DateTime.Now;
            dtpFinal.Value = DateTime.Now;
            txtCantResv.Text = string.Empty;
        }
        private void btnNuevoResv_Click(object sender, EventArgs e)
        {
            limpiar_controles();
            CargarLaboratorios();
            is_reserva_nueva = true;
            HabilitarCampos(true);
            btnGrabarResv.Enabled = true;
            btnEliminarResv.Enabled = false;
            dgvListaReservas.ClearSelection();
            cmbDocente.Focus();
        }

        private void btnGrabarResv_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    if (!ValidarCampos())
            //        return;
            //    Cl_Reserva reserva = new Cl_Reserva();

            //var laboratorioSeleccionado = ln_laboratorio.ObtenerLaboratorioPorNombre(cmbLaboratorio.SelectedItem.ToString());

            //if (is_reserva_nueva)
            //{
            //    reserva.Id = ln_reserva.GetNextId();
            //    reserva.Docente = cmbDocente.SelectedItem.ToString();
            //    reserva.Asignatura = cmbAsignatura.SelectedItem.ToString();
            //    reserva.LaboratorioId = ln_laboratorio.ObtenerLaboratorioPorNombre(cmbLaboratorio.SelectedItem.ToString())[0].Id;
            //    reserva.Fecha = dtpFecha.Value.Date;
            //    reserva.HoraInicio = dtpInicio.Value.TimeOfDay;
            //    reserva.HoraFin = dtpFinal.Value.TimeOfDay;
            //    reserva.CantEstudiantes = int.Parse(txtCantResv.Text);

            //    if (ln_reserva.ValidarDisponibilidad(reserva) && ln_reserva.ValidarCapacidad(reserva, laboratorioSeleccionado[0].Capacidad))
            //    {
            //        ln_reserva.CrearReserva(reserva);
            //        MessageBox.Show("Reserva guardada");
            //        is_reserva_nueva = false;
            //        HabilitarCampos(false);
            //        limpiar_controles();
            //        CargarReservasGrid();

            //        btnGrabarResv.Enabled = false;
            //        btnNuevoResv.Enabled = true;
            //        btnEliminarResv.Enabled = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("El laboratorio no está disponible en la fecha y hora seleccionadas o no hay capacidad para el laboratorio que seleccionaste.");
            //    }
            //}
            //else
            //{
            //    reserva.Id = int.Parse(txtId.Text);
            //    reserva.Docente = cmbDocente.SelectedItem.ToString();
            //    reserva.Asignatura = cmbAsignatura.SelectedItem.ToString();
            //    reserva.LaboratorioId = ln_laboratorio.ObtenerLaboratorioPorNombre(cmbLaboratorio.SelectedItem.ToString())[0].Id;
            //    reserva.Fecha = dtpFecha.Value.Date;
            //    reserva.HoraInicio = dtpInicio.Value.TimeOfDay;
            //    reserva.HoraFin = dtpFinal.Value.TimeOfDay;
            //    reserva.CantEstudiantes = int.Parse(txtCantResv.Text);
            //    if (ln_reserva.ValidarDisponibilidad(reserva) && ln_reserva.ValidarCapacidad(reserva, laboratorioSeleccionado[0].Capacidad))
            //    {
            //        ln_reserva.ModificarReserva(reserva);
            //        MessageBox.Show("Reserva guardada");
            //        is_reserva_nueva = false;
            //        HabilitarCampos(false);
            //        limpiar_controles();
            //        CargarReservasGrid();

            //        btnGrabarResv.Enabled = false;
            //        btnNuevoResv.Enabled = true;
            //        btnEliminarResv.Enabled = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("El laboratorio no está disponible en la fecha y hora seleccionadas.");
            //    }
            //}
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnEliminarResv_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Está seguro de eliminar esta reserva?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                ln_reserva.EliminarReserva(int.Parse(txtId.Text));
                MessageBox.Show("Reserva eliminada");
                CargarReservasGrid();
                limpiar_controles();
                btnGrabarResv.Enabled = false;
                btnEliminarResv.Enabled = false;
                btnNuevoResv.Enabled = true;
            }

        }

        private bool ValidarCampos()
        {
            if (cmbDocente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un docente.");
                cmbDocente.Focus();
                return false;
            }
            if (cmbAsignatura.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una asignatura.");
                cmbAsignatura.Focus();
                return false;
            }
            if (cmbLaboratorio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un laboratorio.");
                cmbLaboratorio.Focus();
                return false;
            }
            if (dtpFinal.Value <= dtpInicio.Value)
            {
                MessageBox.Show("La hora final debe ser posterior a la hora de inicio.");
                dtpFinal.Focus();
                return false;
            }
            if (!int.TryParse(txtCantResv.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de reservas.");
                txtCantResv.Focus();
                return false;
            }
            return true;
        }

        private void txtCantResv_keyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y control de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la tecla
                return;
            }
        }

        private void CargarReservasGrid()
        {
            dgvListaReservas.AutoGenerateColumns = false;
            dgvListaReservas.DataSource = null;
            dgvListaReservas.DataSource = ln_reserva.GetLista();
            dgvListaReservas.ClearSelection();
        }

        private void dgvListaReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (e.RowIndex >= 0)
            //    {
            //        is_reserva_nueva = false;
            //        DataGridViewRow fila = dgvListaReservas.Rows[e.RowIndex];
            //        txtId.Text = fila.Cells["dgvIdResv"].Value?.ToString() ?? "";
            //        cmbDocente.SelectedItem = fila.Cells["dgvDocenteResv"].Value?.ToString() ?? "";
            //        cmbAsignatura.SelectedItem = fila.Cells["dgvAsignaturaResv"].Value?.ToString() ?? "";

            //        cmbLaboratorio.SelectedItem = ln_laboratorio.ObtenerLaboratorioPorId(int.Parse(fila.Cells["dgvLaboratorioResv"].Value.ToString())).Nombre ?? "";
            //        dtpFecha.Value = Convert.ToDateTime(fila.Cells["dgvFechaResv"].Value);
            //        dtpInicio.Value = DateTime.Today.Add((TimeSpan)fila.Cells["dgvHoraInicioResv"].Value);
            //        dtpFinal.Value = DateTime.Today.Add((TimeSpan)fila.Cells["dgvHoraFinResv"].Value);
            //        txtCantResv.Text = fila.Cells["dgvCantidadPersonasResv"].Value?.ToString() ?? "";
            //        HabilitarCampos(true);
            //        btnGrabarResv.Enabled = true;
            //        btnEliminarResv.Enabled = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al cargar los datos de la reserva.");
            //    Console.WriteLine(ex.Message);
            //}

        }

        private void btnBuscarResv_Click(object sender, EventArgs e)
        {
            string nombreLab = txtBuscarResv.Text;

            //var labsCoincidentes = ln_laboratorio.ObtenerLaboratorioPorNombre(nombreLab);
            //if (labsCoincidentes.Count == 0)
            //{
            //    MessageBox.Show("No se encontraron laboratorios.");
            //    return;
            //}
            //var idsLabs = labsCoincidentes
            //    .Select(l => l.Id)
            //    .ToHashSet();

            //var reservasFiltradas = ln_reserva.lista_reservas
            //    .Where(r => idsLabs.Contains(r.LaboratorioId))
            //    .ToList();

            //dgvListaReservas.DataSource = null;
            //dgvListaReservas.DataSource = reservasFiltradas;
            //dgvListaReservas.ClearSelection();
        }

        private void dgvListaReservas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListaReservas.Columns[e.ColumnIndex].Name == "dgvLaboratorioResv")
            {
                if (e.Value != null)
                {
                    int labId = (int)e.Value;
                    //var laboratorio = ln_laboratorio.ObtenerLaboratorioPorId(labId);
                    //if (laboratorio != null)
                    //{
                    //    e.Value = laboratorio.Nombre;
                    //    e.FormattingApplied = true;
                    //}
                }
            }
        }
    }
}
