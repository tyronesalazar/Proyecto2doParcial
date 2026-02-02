namespace CapaPresentacion.UI
{
    partial class FmrReportes : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrReportes));
            panelFmrLab = new Panel();
            btnExportar = new Button();
            panelUsado = new Panel();
            txtLabMasUsado = new TextBox();
            label6 = new Label();
            panelHoras = new Panel();
            txtHorasTotales = new TextBox();
            label5 = new Label();
            panelTotal = new Panel();
            txtReservasTotales = new TextBox();
            label2 = new Label();
            panelBarra = new Panel();
            label7 = new Label();
            label4 = new Label();
            btnGenerarRep = new Button();
            dtpFechaInicio = new DateTimePicker();
            label1 = new Label();
            dtpFechaFin = new DateTimePicker();
            panelTabla = new Panel();
            label11 = new Label();
            dgvGestionLab = new DataGridView();
            dgvlab = new DataGridViewTextBoxColumn();
            dgvLabId = new DataGridViewTextBoxColumn();
            dgvReservasCant = new DataGridViewTextBoxColumn();
            dgvHorasResv = new DataGridViewTextBoxColumn();
            dgvPorcentajeResv = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panelFmrLab.SuspendLayout();
            panelUsado.SuspendLayout();
            panelHoras.SuspendLayout();
            panelTotal.SuspendLayout();
            panelBarra.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionLab).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelFmrLab
            // 
            panelFmrLab.Anchor = AnchorStyles.None;
            panelFmrLab.BackColor = Color.White;
            panelFmrLab.Controls.Add(btnExportar);
            panelFmrLab.Controls.Add(panelUsado);
            panelFmrLab.Controls.Add(panelHoras);
            panelFmrLab.Controls.Add(panelTotal);
            panelFmrLab.Controls.Add(panelBarra);
            panelFmrLab.Controls.Add(panelTabla);
            panelFmrLab.Controls.Add(panel1);
            panelFmrLab.Controls.Add(pictureBox1);
            panelFmrLab.Controls.Add(label3);
            panelFmrLab.Location = new Point(-2, -1);
            panelFmrLab.Name = "panelFmrLab";
            panelFmrLab.Size = new Size(1103, 598);
            panelFmrLab.TabIndex = 8;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(0, 57, 108);
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(948, 556);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(125, 33);
            btnExportar.TabIndex = 29;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // panelUsado
            // 
            panelUsado.BackColor = Color.FromArgb(242, 248, 255);
            panelUsado.Controls.Add(txtLabMasUsado);
            panelUsado.Controls.Add(label6);
            panelUsado.Location = new Point(725, 207);
            panelUsado.Name = "panelUsado";
            panelUsado.Size = new Size(121, 87);
            panelUsado.TabIndex = 28;
            // 
            // txtLabMasUsado
            // 
            txtLabMasUsado.Location = new Point(9, 25);
            txtLabMasUsado.Name = "txtLabMasUsado";
            txtLabMasUsado.ReadOnly = true;
            txtLabMasUsado.Size = new Size(105, 23);
            txtLabMasUsado.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(242, 248, 255);
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 61);
            label6.Name = "label6";
            label6.Size = new Size(105, 18);
            label6.TabIndex = 26;
            label6.Text = "Más Utilizado";
            // 
            // panelHoras
            // 
            panelHoras.BackColor = Color.FromArgb(242, 248, 255);
            panelHoras.Controls.Add(txtHorasTotales);
            panelHoras.Controls.Add(label5);
            panelHoras.Location = new Point(485, 207);
            panelHoras.Name = "panelHoras";
            panelHoras.Size = new Size(121, 87);
            panelHoras.TabIndex = 28;
            // 
            // txtHorasTotales
            // 
            txtHorasTotales.Location = new Point(36, 25);
            txtHorasTotales.Name = "txtHorasTotales";
            txtHorasTotales.ReadOnly = true;
            txtHorasTotales.Size = new Size(53, 23);
            txtHorasTotales.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(242, 248, 255);
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 61);
            label5.Name = "label5";
            label5.Size = new Size(103, 18);
            label5.TabIndex = 26;
            label5.Text = "Horas Totales";
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.FromArgb(242, 248, 255);
            panelTotal.Controls.Add(txtReservasTotales);
            panelTotal.Controls.Add(label2);
            panelTotal.Location = new Point(244, 207);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(121, 87);
            panelTotal.TabIndex = 27;
            // 
            // txtReservasTotales
            // 
            txtReservasTotales.Location = new Point(36, 25);
            txtReservasTotales.Name = "txtReservasTotales";
            txtReservasTotales.ReadOnly = true;
            txtReservasTotales.ShortcutsEnabled = false;
            txtReservasTotales.Size = new Size(53, 23);
            txtReservasTotales.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 248, 255);
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 61);
            label2.Name = "label2";
            label2.Size = new Size(110, 18);
            label2.TabIndex = 26;
            label2.Text = "Total Reservas";
            // 
            // panelBarra
            // 
            panelBarra.BackColor = Color.FromArgb(242, 248, 255);
            panelBarra.Controls.Add(label7);
            panelBarra.Controls.Add(label4);
            panelBarra.Controls.Add(btnGenerarRep);
            panelBarra.Controls.Add(dtpFechaInicio);
            panelBarra.Controls.Add(label1);
            panelBarra.Controls.Add(dtpFechaFin);
            panelBarra.Location = new Point(27, 142);
            panelBarra.Name = "panelBarra";
            panelBarra.Size = new Size(1046, 56);
            panelBarra.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(242, 248, 255);
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(192, 16);
            label7.Name = "label7";
            label7.Size = new Size(68, 22);
            label7.TabIndex = 26;
            label7.Text = "Desde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(242, 248, 255);
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 57, 108);
            label4.Location = new Point(15, 16);
            label4.Name = "label4";
            label4.Size = new Size(171, 23);
            label4.TabIndex = 21;
            label4.Text = "Rango de fechas:";
            // 
            // btnGenerarRep
            // 
            btnGenerarRep.BackColor = Color.FromArgb(0, 57, 108);
            btnGenerarRep.FlatAppearance.BorderSize = 0;
            btnGenerarRep.FlatStyle = FlatStyle.Flat;
            btnGenerarRep.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarRep.ForeColor = Color.White;
            btnGenerarRep.Location = new Point(851, 10);
            btnGenerarRep.Name = "btnGenerarRep";
            btnGenerarRep.Size = new Size(166, 33);
            btnGenerarRep.TabIndex = 25;
            btnGenerarRep.Text = "Generar Reporte";
            btnGenerarRep.UseVisualStyleBackColor = false;
            btnGenerarRep.Click += btnGenerarRep_Click;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(266, 12);
            dtpFechaInicio.MaxDate = new DateTime(2027, 2, 6, 0, 0, 0, 0);
            dtpFechaInicio.MinDate = new DateTime(2025, 11, 30, 0, 0, 0, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(199, 29);
            dtpFechaInicio.TabIndex = 22;
            dtpFechaInicio.Value = new DateTime(2025, 11, 30, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 248, 255);
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(484, 16);
            label1.Name = "label1";
            label1.Size = new Size(62, 22);
            label1.TabIndex = 24;
            label1.Text = "hasta";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaFin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(570, 12);
            dtpFechaFin.MaxDate = new DateTime(2027, 2, 6, 0, 0, 0, 0);
            dtpFechaFin.MinDate = new DateTime(2025, 11, 30, 0, 0, 0, 0);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(199, 29);
            dtpFechaFin.TabIndex = 23;
            dtpFechaFin.Value = new DateTime(2025, 11, 30, 0, 0, 0, 0);
            // 
            // panelTabla
            // 
            panelTabla.AccessibleRole = AccessibleRole.None;
            panelTabla.BackColor = Color.FromArgb(242, 248, 255);
            panelTabla.Controls.Add(label11);
            panelTabla.Controls.Add(dgvGestionLab);
            panelTabla.Location = new Point(27, 303);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(1046, 244);
            panelTabla.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(242, 248, 255);
            label11.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(0, 57, 108);
            label11.Location = new Point(405, 10);
            label11.Name = "label11";
            label11.Size = new Size(223, 23);
            label11.TabIndex = 35;
            label11.Text = "Detalle por Laboratorio";
            // 
            // dgvGestionLab
            // 
            dgvGestionLab.AllowUserToAddRows = false;
            dgvGestionLab.AllowUserToDeleteRows = false;
            dgvGestionLab.Anchor = AnchorStyles.Top;
            dgvGestionLab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestionLab.BackgroundColor = Color.FromArgb(242, 248, 255);
            dgvGestionLab.BorderStyle = BorderStyle.None;
            dgvGestionLab.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvGestionLab.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvGestionLab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvGestionLab.ColumnHeadersHeight = 43;
            dgvGestionLab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGestionLab.Columns.AddRange(new DataGridViewColumn[] { dgvlab, dgvLabId, dgvReservasCant, dgvHorasResv, dgvPorcentajeResv });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(242, 248, 255);
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvGestionLab.DefaultCellStyle = dataGridViewCellStyle10;
            dgvGestionLab.EnableHeadersVisualStyles = false;
            dgvGestionLab.GridColor = Color.FromArgb(0, 57, 108);
            dgvGestionLab.Location = new Point(26, 40);
            dgvGestionLab.MultiSelect = false;
            dgvGestionLab.Name = "dgvGestionLab";
            dgvGestionLab.ReadOnly = true;
            dgvGestionLab.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle11.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvGestionLab.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(242, 248, 255);
            dataGridViewCellStyle12.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(213, 232, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dgvGestionLab.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvGestionLab.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionLab.ShowCellErrors = false;
            dgvGestionLab.ShowCellToolTips = false;
            dgvGestionLab.ShowEditingIcon = false;
            dgvGestionLab.ShowRowErrors = false;
            dgvGestionLab.Size = new Size(991, 180);
            dgvGestionLab.TabIndex = 0;
            // 
            // dgvlab
            // 
            dgvlab.DataPropertyName = "laboratorio";
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvlab.DefaultCellStyle = dataGridViewCellStyle8;
            dgvlab.FillWeight = 200F;
            dgvlab.HeaderText = "Laboratorio";
            dgvlab.MinimumWidth = 20;
            dgvlab.Name = "dgvlab";
            dgvlab.ReadOnly = true;
            // 
            // dgvLabId
            // 
            dgvLabId.DataPropertyName = "LaboratorioId";
            dgvLabId.HeaderText = "id Lab";
            dgvLabId.Name = "dgvLabId";
            dgvLabId.ReadOnly = true;
            dgvLabId.Visible = false;
            // 
            // dgvReservasCant
            // 
            dgvReservasCant.DataPropertyName = "cantidad_reservas";
            dgvReservasCant.FillWeight = 200F;
            dgvReservasCant.HeaderText = "Reservas";
            dgvReservasCant.MinimumWidth = 20;
            dgvReservasCant.Name = "dgvReservasCant";
            dgvReservasCant.ReadOnly = true;
            // 
            // dgvHorasResv
            // 
            dgvHorasResv.DataPropertyName = "horas_usadas";
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvHorasResv.DefaultCellStyle = dataGridViewCellStyle9;
            dgvHorasResv.HeaderText = "Horas";
            dgvHorasResv.Name = "dgvHorasResv";
            dgvHorasResv.ReadOnly = true;
            // 
            // dgvPorcentajeResv
            // 
            dgvPorcentajeResv.DataPropertyName = "porcentaje_uso";
            dgvPorcentajeResv.FillWeight = 200F;
            dgvPorcentajeResv.HeaderText = "% uso";
            dgvPorcentajeResv.MinimumWidth = 20;
            dgvPorcentajeResv.Name = "dgvPorcentajeResv";
            dgvPorcentajeResv.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(27, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 3);
            panel1.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Location = new Point(0, 447);
            panel4.Name = "panel4";
            panel4.Size = new Size(1890, 3);
            panel4.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 57, 108);
            label3.Location = new Point(147, 39);
            label3.Name = "label3";
            label3.Size = new Size(527, 57);
            label3.TabIndex = 10;
            label3.Text = "Resumen de Reservas";
            // 
            // FmrReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 597);
            Controls.Add(panelFmrLab);
            Name = "FmrReportes";
            Text = "FmrReportes";
            panelFmrLab.ResumeLayout(false);
            panelFmrLab.PerformLayout();
            panelUsado.ResumeLayout(false);
            panelUsado.PerformLayout();
            panelHoras.ResumeLayout(false);
            panelHoras.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            panelBarra.ResumeLayout(false);
            panelBarra.PerformLayout();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionLab).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFmrLab;
        private Panel panelTabla;
        private Label label11;
        private DataGridView dgvGestionLab;
        private Panel panel1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label label1;
        private Panel panelBarra;
        private Button btnGenerarRep;
        private Panel panelTotal;
        private Label label2;
        private Panel panelUsado;
        private TextBox txtLabMasUsado;
        private Label label6;
        private Panel panelHoras;
        private TextBox txtHorasTotales;
        private Label label5;
        private TextBox txtReservasTotales;
        private Label label7;
        private DataGridViewTextBoxColumn dgvlab;
        private DataGridViewTextBoxColumn dgvLabId;
        private DataGridViewTextBoxColumn dgvReservasCant;
        private DataGridViewTextBoxColumn dgvHorasResv;
        private DataGridViewTextBoxColumn dgvPorcentajeResv;
        private Button btnExportar;
    }
}