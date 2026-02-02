using CapaLogicaNegocio.LogicaNegocio;
using CapaLogicaNegocio.Modelos;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Data;
using System.Drawing.Drawing2D;

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
            try
            {
                DataTable reservas = ln_reserva.GetReservasEnIntervalo(dtpFechaInicio.Value, dtpFechaFin.Value);

                if (reservas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay reservas en el intervalo seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvGestionLab.DataSource = null;
                }
                else
                {
                    Cl_DetallesReportes detalles = ln_reportes.GenerarReporte(reservas);

                    dgvGestionLab.DataSource = null;
                    dgvGestionLab.AutoGenerateColumns = false;
                    dgvGestionLab.DataSource = reservas;

                    txtHorasTotales.Text = detalles.TotalHoras.ToString();
                    txtReservasTotales.Text = detalles.TotalReservas.ToString();
                    txtLabMasUsado.Text = detalles.LabMasUsado;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ocurrió un error al generar el reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        private void GenerarPdf()
        {
            try
            {
                using SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                sfd.Title = "Guardar reporte";
                sfd.FileName = $"reporte_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                using var writer = new PdfWriter(sfd.FileName);
                using var pdf = new PdfDocument(writer);
                using var document = new iText.Layout.Document(pdf);

                document.Add(new Paragraph("Reporte de reservas")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(18)
                    .SimulateBold());

                document.Add(new Paragraph($"Desde: {dtpFechaInicio.Value:dd/MM/yyyy} Hasta: {dtpFechaFin.Value:dd/MM/yyyy}")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(12)
                    .SetMarginBottom(20));

                document.Add(new Paragraph($"Total de reservas: {txtReservasTotales.Text}"));
                document.Add(new Paragraph($"Total de horas reservadas: {txtHorasTotales.Text}"));
                document.Add(new Paragraph($"Laboratorio más usado: {txtLabMasUsado.Text}")
                    .SetMarginBottom(20));

                Table tabla = new Table(dgvGestionLab.Columns.Count);
                tabla.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (DataGridViewColumn col in dgvGestionLab.Columns)
                {
                    if (!col.Visible) continue;
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(col.HeaderText).SimulateBold()));
                }
                foreach (DataGridViewRow row in dgvGestionLab.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (!cell.OwningColumn.Visible) continue;
                        tabla.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? "")));
                    }
                }
                document.Add(tabla);
                MessageBox.Show("Reporte exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al exportar el reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            GenerarPdf();
        }
    }
}
