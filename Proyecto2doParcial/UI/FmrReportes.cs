using CapaLogicaNegocio.LogicaNegocio;
using CapaLogicaNegocio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.UI
{
    public partial class FmrReportes : Form
    {
        Cl_LN_Reportes ln_reportes;
        Cl_LN_Reserva ln_reserva;
        Cl_LN_Laboratorio ln_laboratorio;
        public FmrReportes(Cl_LN_Reportes ln, Cl_LN_Reserva ln_res, Cl_LN_Laboratorio ln_lab)
        {
            ln_reportes = ln;
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
            RedondearPanel(panelTabla, 60);
            RedondearPanel(panelBarra, 30);
            RedondearPanel(panelTotal, 30);
            RedondearPanel(panelHoras, 30);
            RedondearPanel(panelUsado, 30);

        }
        private void btnGenerarRep_Click(object sender, EventArgs e)
        {
            var reservas = ln_reserva.GetReservasEnIntervalo(dtpFechaInicio.Value, dtpFechaFin.Value);
            if (reservas.Count == 0)
            {
                MessageBox.Show("No hay reservas en el intervalo seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvGestionLab.DataSource = null;
            }
            else
            {
                int totalReservas = reservas.Count;
                double horasTotales = ln_reserva.ObtenerHorasTotales(reservas);

                var reservasAgrupadas = ln_reportes.GenerarReporteReservas(reservas, horasTotales);
                int idLabMasUsado = reservasAgrupadas.OrderByDescending(r => r.HorasReservadas).First().LaboratorioId;

                dgvGestionLab.DataSource = null;
                dgvGestionLab.AutoGenerateColumns = false;
                dgvGestionLab.DataSource = reservasAgrupadas;

                txtHorasTotales.Text = horasTotales.ToString("F2");
                txtReservasTotales.Text = totalReservas.ToString();
                //txtLabMasUsado.Text = ln_laboratorio.ObtenerLaboratorioPorId(idLabMasUsado)?.Nombre ?? "N/A";

            }
        }

        private void dgvGestionLab_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvGestionLab.Columns[e.ColumnIndex].Name == "dgvlab")
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
