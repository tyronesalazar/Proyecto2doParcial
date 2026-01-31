using CapaLogicaNegocio.Modelos;
namespace APPreservaLabUI.UI
{
    partial class FmrReservas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrReservas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvLaboratorios = new DataGridView();
            nomLab = new DataGridViewTextBoxColumn();
            capacidadLab = new DataGridViewTextBoxColumn();
            estadoLab = new DataGridViewTextBoxColumn();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnBuscarLab = new Button();
            panelNueva = new Panel();
            label12 = new Label();
            dtpFinal = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            label9 = new Label();
            panelCapLab = new Panel();
            txtCantResv = new TextBox();
            dtpFecha = new DateTimePicker();
            cmbLaboratorio = new ComboBox();
            cmbAsignatura = new ComboBox();
            cmbDocente = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            panelBuscarLab = new Panel();
            txtBuscarLab = new TextBox();
            panelTabla = new Panel();
            dgvListaReservas = new DataGridView();
            label11 = new Label();
            clReservaBindingSource = new BindingSource(components);
            label10 = new Label();
            btnNuevoResv = new Button();
            btnGrabarResv = new Button();
            btnBuscarResv = new Button();
            panel1 = new Panel();
            txtBuscarResv = new TextBox();
            panel3 = new Panel();
            btnEliminarResv = new Button();
            panelFmrLab = new Panel();
            txtId = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            dgvIdResv = new DataGridViewTextBoxColumn();
            dgvDocenteResv = new DataGridViewTextBoxColumn();
            dgvAsignaturaResv = new DataGridViewTextBoxColumn();
            dgvLaboratorioResv = new DataGridViewTextBoxColumn();
            dgvFechaResv = new DataGridViewTextBoxColumn();
            dgvHoraInicioResv = new DataGridViewTextBoxColumn();
            dgvHoraFinResv = new DataGridViewTextBoxColumn();
            dgvCantidadPersonasResv = new DataGridViewTextBoxColumn();
            dvgEstado = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelNueva.SuspendLayout();
            panelCapLab.SuspendLayout();
            panelBuscarLab.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaReservas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clReservaBindingSource).BeginInit();
            panel1.SuspendLayout();
            panelFmrLab.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLaboratorios
            // 
            dgvLaboratorios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvLaboratorios.BackgroundColor = Color.White;
            dgvLaboratorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaboratorios.Columns.AddRange(new DataGridViewColumn[] { nomLab, capacidadLab, estadoLab });
            dgvLaboratorios.Location = new Point(1617, 307);
            dgvLaboratorios.Name = "dgvLaboratorios";
            dgvLaboratorios.Size = new Size(343, 49);
            dgvLaboratorios.TabIndex = 0;
            // 
            // nomLab
            // 
            nomLab.HeaderText = "Nombre";
            nomLab.Name = "nomLab";
            // 
            // capacidadLab
            // 
            capacidadLab.HeaderText = "Capacidad";
            capacidadLab.Name = "capacidadLab";
            // 
            // estadoLab
            // 
            estadoLab.HeaderText = "Estado";
            estadoLab.Name = "estadoLab";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 57, 108);
            label3.Location = new Point(147, 39);
            label3.Name = "label3";
            label3.Size = new Size(489, 57);
            label3.TabIndex = 10;
            label3.Text = "Gestión de Reservas";
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
            // btnBuscarLab
            // 
            btnBuscarLab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarLab.BackColor = Color.FromArgb(242, 248, 255);
            btnBuscarLab.FlatAppearance.BorderSize = 0;
            btnBuscarLab.FlatStyle = FlatStyle.Flat;
            btnBuscarLab.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarLab.ForeColor = Color.FromArgb(0, 57, 108);
            btnBuscarLab.Location = new Point(1617, 224);
            btnBuscarLab.Name = "btnBuscarLab";
            btnBuscarLab.Size = new Size(114, 43);
            btnBuscarLab.TabIndex = 12;
            btnBuscarLab.Text = "Buscar";
            btnBuscarLab.UseVisualStyleBackColor = false;
            // 
            // panelNueva
            // 
            panelNueva.BackColor = Color.FromArgb(242, 248, 255);
            panelNueva.Controls.Add(label12);
            panelNueva.Controls.Add(dtpFinal);
            panelNueva.Controls.Add(dtpInicio);
            panelNueva.Controls.Add(label9);
            panelNueva.Controls.Add(panelCapLab);
            panelNueva.Controls.Add(dtpFecha);
            panelNueva.Controls.Add(cmbLaboratorio);
            panelNueva.Controls.Add(cmbAsignatura);
            panelNueva.Controls.Add(cmbDocente);
            panelNueva.Controls.Add(label8);
            panelNueva.Controls.Add(label7);
            panelNueva.Controls.Add(label6);
            panelNueva.Controls.Add(label5);
            panelNueva.Controls.Add(label1);
            panelNueva.Controls.Add(label2);
            panelNueva.Location = new Point(26, 199);
            panelNueva.Name = "panelNueva";
            panelNueva.Size = new Size(447, 274);
            panelNueva.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(88, 224);
            label12.Name = "label12";
            label12.Size = new Size(16, 21);
            label12.TabIndex = 30;
            label12.Text = "-";
            // 
            // dtpFinal
            // 
            dtpFinal.Enabled = false;
            dtpFinal.Format = DateTimePickerFormat.Time;
            dtpFinal.Location = new Point(110, 224);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.ShowUpDown = true;
            dtpFinal.Size = new Size(69, 23);
            dtpFinal.TabIndex = 29;
            // 
            // dtpInicio
            // 
            dtpInicio.Enabled = false;
            dtpInicio.Format = DateTimePickerFormat.Time;
            dtpInicio.Location = new Point(17, 224);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowUpDown = true;
            dtpInicio.Size = new Size(69, 23);
            dtpInicio.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14.25F);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(302, 232);
            label9.Name = "label9";
            label9.Size = new Size(92, 22);
            label9.TabIndex = 27;
            label9.Text = "personas";
            // 
            // panelCapLab
            // 
            panelCapLab.BackColor = Color.FromArgb(213, 232, 255);
            panelCapLab.Controls.Add(txtCantResv);
            panelCapLab.Location = new Point(233, 225);
            panelCapLab.Name = "panelCapLab";
            panelCapLab.Size = new Size(63, 29);
            panelCapLab.TabIndex = 26;
            // 
            // txtCantResv
            // 
            txtCantResv.BackColor = Color.FromArgb(213, 232, 255);
            txtCantResv.BorderStyle = BorderStyle.None;
            txtCantResv.Enabled = false;
            txtCantResv.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantResv.Location = new Point(13, 5);
            txtCantResv.Name = "txtCantResv";
            txtCantResv.Size = new Size(39, 20);
            txtCantResv.TabIndex = 4;
            txtCantResv.KeyPress += txtCantResv_keyPress;
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Enabled = false;
            dtpFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(233, 134);
            dtpFecha.MaxDate = new DateTime(2027, 2, 6, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(2025, 11, 30, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(199, 29);
            dtpFecha.TabIndex = 20;
            dtpFecha.Value = new DateTime(2025, 11, 30, 0, 0, 0, 0);
            // 
            // cmbLaboratorio
            // 
            cmbLaboratorio.BackColor = Color.FromArgb(213, 232, 255);
            cmbLaboratorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLaboratorio.Enabled = false;
            cmbLaboratorio.FlatStyle = FlatStyle.Flat;
            cmbLaboratorio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLaboratorio.FormattingEnabled = true;
            cmbLaboratorio.Location = new Point(17, 134);
            cmbLaboratorio.Name = "cmbLaboratorio";
            cmbLaboratorio.Size = new Size(199, 29);
            cmbLaboratorio.TabIndex = 2;
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.BackColor = Color.FromArgb(213, 232, 255);
            cmbAsignatura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAsignatura.Enabled = false;
            cmbAsignatura.FlatStyle = FlatStyle.Flat;
            cmbAsignatura.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Items.AddRange(new object[] { "Mod. Software", "POO", "Alg. Logica progrmación", "POE" });
            cmbAsignatura.Location = new Point(233, 54);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(199, 29);
            cmbAsignatura.TabIndex = 2;
            // 
            // cmbDocente
            // 
            cmbDocente.BackColor = Color.FromArgb(213, 232, 255);
            cmbDocente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDocente.Enabled = false;
            cmbDocente.FlatStyle = FlatStyle.Flat;
            cmbDocente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDocente.FormattingEnabled = true;
            cmbDocente.Items.AddRange(new object[] { "Ing. Manuela Intriago", "Ing. Jacinto Ramirez", "Ing. Pablo Salcedo" });
            cmbDocente.Location = new Point(17, 54);
            cmbDocente.Name = "cmbDocente";
            cmbDocente.Size = new Size(199, 29);
            cmbDocente.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(242, 248, 255);
            label8.Font = new Font("Century Gothic", 12F);
            label8.Location = new Point(233, 185);
            label8.Name = "label8";
            label8.Size = new Size(185, 21);
            label8.TabIndex = 25;
            label8.Text = "Cantidad Estudiantes:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(242, 248, 255);
            label7.Font = new Font("Century Gothic", 12F);
            label7.Location = new Point(17, 185);
            label7.Name = "label7";
            label7.Size = new Size(69, 21);
            label7.TabIndex = 22;
            label7.Text = "Horario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(242, 248, 255);
            label6.Font = new Font("Century Gothic", 12F);
            label6.Location = new Point(233, 103);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 21;
            label6.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(242, 248, 255);
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(233, 16);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 19;
            label5.Text = "Asignatura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 248, 255);
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 1;
            label1.Text = "Docente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 248, 255);
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(17, 103);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 3;
            label2.Text = "Laboratorio:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 57, 108);
            label4.Location = new Point(-97, 204);
            label4.Name = "label4";
            label4.Size = new Size(0, 38);
            label4.TabIndex = 17;
            // 
            // panelBuscarLab
            // 
            panelBuscarLab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelBuscarLab.BackColor = Color.FromArgb(242, 248, 255);
            panelBuscarLab.Controls.Add(txtBuscarLab);
            panelBuscarLab.Location = new Point(1744, 224);
            panelBuscarLab.Name = "panelBuscarLab";
            panelBuscarLab.Size = new Size(400, 43);
            panelBuscarLab.TabIndex = 18;
            // 
            // txtBuscarLab
            // 
            txtBuscarLab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarLab.BackColor = Color.FromArgb(242, 248, 255);
            txtBuscarLab.BorderStyle = BorderStyle.None;
            txtBuscarLab.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarLab.ForeColor = Color.Gray;
            txtBuscarLab.Location = new Point(222, 12);
            txtBuscarLab.Name = "txtBuscarLab";
            txtBuscarLab.Size = new Size(352, 20);
            txtBuscarLab.TabIndex = 13;
            txtBuscarLab.Text = "Buscar Laboratorio...";
            // 
            // panelTabla
            // 
            panelTabla.AccessibleRole = AccessibleRole.None;
            panelTabla.BackColor = Color.FromArgb(242, 248, 255);
            panelTabla.Controls.Add(dgvListaReservas);
            panelTabla.Controls.Add(label11);
            panelTabla.Location = new Point(515, 199);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(564, 340);
            panelTabla.TabIndex = 29;
            // 
            // dgvListaReservas
            // 
            dgvListaReservas.AllowUserToAddRows = false;
            dgvListaReservas.AllowUserToDeleteRows = false;
            dgvListaReservas.AllowUserToResizeRows = false;
            dgvListaReservas.BackgroundColor = Color.FromArgb(242, 248, 255);
            dgvListaReservas.BorderStyle = BorderStyle.None;
            dgvListaReservas.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListaReservas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaReservas.ColumnHeadersHeight = 43;
            dgvListaReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaReservas.Columns.AddRange(new DataGridViewColumn[] { dgvIdResv, dgvDocenteResv, dgvAsignaturaResv, dgvLaboratorioResv, dgvFechaResv, dgvHoraInicioResv, dgvHoraFinResv, dgvCantidadPersonasResv, dvgEstado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 248, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListaReservas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListaReservas.EnableHeadersVisualStyles = false;
            dgvListaReservas.GridColor = Color.FromArgb(0, 57, 108);
            dgvListaReservas.Location = new Point(21, 37);
            dgvListaReservas.Name = "dgvListaReservas";
            dgvListaReservas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListaReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(242, 248, 255);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvListaReservas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListaReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaReservas.ShowCellErrors = false;
            dgvListaReservas.ShowCellToolTips = false;
            dgvListaReservas.ShowEditingIcon = false;
            dgvListaReservas.ShowRowErrors = false;
            dgvListaReservas.Size = new Size(530, 268);
            dgvListaReservas.TabIndex = 0;
            dgvListaReservas.CellContentClick += dgvListaReservas_CellContentClick;
            dgvListaReservas.CellFormatting += dgvListaReservas_CellFormatting;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(242, 248, 255);
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(0, 57, 108);
            label11.Location = new Point(214, 8);
            label11.Name = "label11";
            label11.Size = new Size(136, 19);
            label11.TabIndex = 34;
            label11.Text = "Lista de Reservas";
            // 
            // clReservaBindingSource
            // 
            clReservaBindingSource.DataSource = typeof(Cl_Reserva);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 57, 108);
            label10.Location = new Point(26, 154);
            label10.Name = "label10";
            label10.Size = new Size(185, 23);
            label10.TabIndex = 30;
            label10.Text = "Formulario Reserva";
            // 
            // btnNuevoResv
            // 
            btnNuevoResv.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNuevoResv.BackColor = Color.FromArgb(0, 57, 108);
            btnNuevoResv.Cursor = Cursors.Hand;
            btnNuevoResv.FlatAppearance.BorderSize = 0;
            btnNuevoResv.FlatStyle = FlatStyle.Flat;
            btnNuevoResv.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoResv.ForeColor = Color.White;
            btnNuevoResv.Location = new Point(58, 491);
            btnNuevoResv.Name = "btnNuevoResv";
            btnNuevoResv.Size = new Size(114, 33);
            btnNuevoResv.TabIndex = 31;
            btnNuevoResv.Text = "Nuevo";
            btnNuevoResv.UseVisualStyleBackColor = false;
            btnNuevoResv.Click += btnNuevoResv_Click;
            // 
            // btnGrabarResv
            // 
            btnGrabarResv.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGrabarResv.BackColor = Color.FromArgb(0, 57, 108);
            btnGrabarResv.Cursor = Cursors.Hand;
            btnGrabarResv.Enabled = false;
            btnGrabarResv.FlatAppearance.BorderSize = 0;
            btnGrabarResv.FlatStyle = FlatStyle.Flat;
            btnGrabarResv.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrabarResv.ForeColor = Color.White;
            btnGrabarResv.Location = new Point(197, 491);
            btnGrabarResv.Name = "btnGrabarResv";
            btnGrabarResv.Size = new Size(114, 33);
            btnGrabarResv.TabIndex = 33;
            btnGrabarResv.Text = "Grabar";
            btnGrabarResv.UseVisualStyleBackColor = false;
            btnGrabarResv.Click += btnGrabarResv_Click;
            // 
            // btnBuscarResv
            // 
            btnBuscarResv.BackColor = Color.FromArgb(0, 57, 108);
            btnBuscarResv.Cursor = Cursors.Hand;
            btnBuscarResv.FlatAppearance.BorderSize = 0;
            btnBuscarResv.FlatStyle = FlatStyle.Flat;
            btnBuscarResv.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarResv.ForeColor = Color.White;
            btnBuscarResv.Location = new Point(515, 150);
            btnBuscarResv.Name = "btnBuscarResv";
            btnBuscarResv.Size = new Size(114, 33);
            btnBuscarResv.TabIndex = 35;
            btnBuscarResv.Text = "Buscar";
            btnBuscarResv.UseVisualStyleBackColor = false;
            btnBuscarResv.Click += btnBuscarResv_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 248, 255);
            panel1.Controls.Add(txtBuscarResv);
            panel1.Location = new Point(646, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 33);
            panel1.TabIndex = 36;
            // 
            // txtBuscarResv
            // 
            txtBuscarResv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarResv.BackColor = Color.FromArgb(242, 248, 255);
            txtBuscarResv.BorderStyle = BorderStyle.None;
            txtBuscarResv.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarResv.ForeColor = Color.Gray;
            txtBuscarResv.Location = new Point(14, 7);
            txtBuscarResv.Name = "txtBuscarResv";
            txtBuscarResv.PlaceholderText = "Buscar Reserva...";
            txtBuscarResv.Size = new Size(406, 20);
            txtBuscarResv.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(235, 235, 235);
            panel3.Location = new Point(494, 170);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 390);
            panel3.TabIndex = 37;
            // 
            // btnEliminarResv
            // 
            btnEliminarResv.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarResv.BackColor = Color.FromArgb(0, 57, 108);
            btnEliminarResv.Cursor = Cursors.Hand;
            btnEliminarResv.Enabled = false;
            btnEliminarResv.FlatAppearance.BorderSize = 0;
            btnEliminarResv.FlatStyle = FlatStyle.Flat;
            btnEliminarResv.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarResv.ForeColor = Color.White;
            btnEliminarResv.Location = new Point(328, 491);
            btnEliminarResv.Name = "btnEliminarResv";
            btnEliminarResv.Size = new Size(114, 33);
            btnEliminarResv.TabIndex = 39;
            btnEliminarResv.Text = "Eliminar";
            btnEliminarResv.UseVisualStyleBackColor = false;
            btnEliminarResv.Click += btnEliminarResv_Click;
            // 
            // panelFmrLab
            // 
            panelFmrLab.Anchor = AnchorStyles.None;
            panelFmrLab.BackColor = Color.White;
            panelFmrLab.Controls.Add(txtId);
            panelFmrLab.Controls.Add(panel2);
            panelFmrLab.Controls.Add(btnEliminarResv);
            panelFmrLab.Controls.Add(panel3);
            panelFmrLab.Controls.Add(panel1);
            panelFmrLab.Controls.Add(btnBuscarResv);
            panelFmrLab.Controls.Add(btnGrabarResv);
            panelFmrLab.Controls.Add(btnNuevoResv);
            panelFmrLab.Controls.Add(label10);
            panelFmrLab.Controls.Add(panelTabla);
            panelFmrLab.Controls.Add(panelBuscarLab);
            panelFmrLab.Controls.Add(label4);
            panelFmrLab.Controls.Add(panelNueva);
            panelFmrLab.Controls.Add(btnBuscarLab);
            panelFmrLab.Controls.Add(pictureBox1);
            panelFmrLab.Controls.Add(label3);
            panelFmrLab.Controls.Add(dgvLaboratorios);
            panelFmrLab.Location = new Point(0, 0);
            panelFmrLab.Name = "panelFmrLab";
            panelFmrLab.Size = new Size(1103, 598);
            panelFmrLab.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(309, 157);
            txtId.Name = "txtId";
            txtId.Size = new Size(51, 23);
            txtId.TabIndex = 31;
            txtId.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(27, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 3);
            panel2.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Location = new Point(0, 447);
            panel4.Name = "panel4";
            panel4.Size = new Size(1900, 3);
            panel4.TabIndex = 15;
            // 
            // dgvIdResv
            // 
            dgvIdResv.DataPropertyName = "Id";
            dgvIdResv.HeaderText = "id";
            dgvIdResv.Name = "dgvIdResv";
            dgvIdResv.Visible = false;
            dgvIdResv.Width = 47;
            // 
            // dgvDocenteResv
            // 
            dgvDocenteResv.DataPropertyName = "Docente";
            dgvDocenteResv.HeaderText = "Docente";
            dgvDocenteResv.Name = "dgvDocenteResv";
            dgvDocenteResv.ReadOnly = true;
            dgvDocenteResv.Width = 102;
            // 
            // dgvAsignaturaResv
            // 
            dgvAsignaturaResv.DataPropertyName = "Asignatura";
            dgvAsignaturaResv.HeaderText = "Asignatura";
            dgvAsignaturaResv.Name = "dgvAsignaturaResv";
            dgvAsignaturaResv.ReadOnly = true;
            dgvAsignaturaResv.Width = 120;
            // 
            // dgvLaboratorioResv
            // 
            dgvLaboratorioResv.DataPropertyName = "laboratorio_id";
            dgvLaboratorioResv.HeaderText = "Laboratorio";
            dgvLaboratorioResv.Name = "dgvLaboratorioResv";
            dgvLaboratorioResv.ReadOnly = true;
            dgvLaboratorioResv.Width = 123;
            // 
            // dgvFechaResv
            // 
            dgvFechaResv.DataPropertyName = "Fecha";
            dgvFechaResv.HeaderText = "Fecha";
            dgvFechaResv.Name = "dgvFechaResv";
            dgvFechaResv.ReadOnly = true;
            dgvFechaResv.Width = 82;
            // 
            // dgvHoraInicioResv
            // 
            dgvHoraInicioResv.DataPropertyName = "hora_Inicio";
            dgvHoraInicioResv.HeaderText = "Inicio de clase";
            dgvHoraInicioResv.Name = "dgvHoraInicioResv";
            dgvHoraInicioResv.ReadOnly = true;
            dgvHoraInicioResv.Width = 143;
            // 
            // dgvHoraFinResv
            // 
            dgvHoraFinResv.DataPropertyName = "hora_Fin";
            dgvHoraFinResv.HeaderText = "Fin de la clase";
            dgvHoraFinResv.Name = "dgvHoraFinResv";
            dgvHoraFinResv.ReadOnly = true;
            dgvHoraFinResv.Width = 141;
            // 
            // dgvCantidadPersonasResv
            // 
            dgvCantidadPersonasResv.DataPropertyName = "cant_estudiantes";
            dgvCantidadPersonasResv.HeaderText = "Cantidad Alumnos";
            dgvCantidadPersonasResv.Name = "dgvCantidadPersonasResv";
            dgvCantidadPersonasResv.ReadOnly = true;
            dgvCantidadPersonasResv.Width = 181;
            // 
            // dvgEstado
            // 
            dvgEstado.DataPropertyName = "estado";
            dvgEstado.HeaderText = "Estado";
            dvgEstado.Items.AddRange(new object[] { "activo", "finalizada", "cancelada" });
            dvgEstado.Name = "dvgEstado";
            dvgEstado.Resizable = DataGridViewTriState.True;
            dvgEstado.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FmrReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 597);
            Controls.Add(panelFmrLab);
            Name = "FmrReservas";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelNueva.ResumeLayout(false);
            panelNueva.PerformLayout();
            panelCapLab.ResumeLayout(false);
            panelCapLab.PerformLayout();
            panelBuscarLab.ResumeLayout(false);
            panelBuscarLab.PerformLayout();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaReservas).EndInit();
            ((System.ComponentModel.ISupportInitialize)clReservaBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFmrLab.ResumeLayout(false);
            panelFmrLab.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnEditarLab;
        private Button btnEliminarLab;
        private Button button2;
        private Button button1;
        private ComboBox cmbEstudiantes;
        private DataGridView dgvLaboratorios;
        private DataGridViewTextBoxColumn nomLab;
        private DataGridViewTextBoxColumn capacidadLab;
        private DataGridViewTextBoxColumn estadoLab;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnBuscarLab;
        private Panel panelNueva;
        private Label label9;
        private Panel panelCapLab;
        private TextBox txtCantResv;
        private DateTimePicker dtpFecha;
        private ComboBox cmbLaboratorio;
        private ComboBox cmbAsignatura;
        private ComboBox cmbDocente;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label4;
        private Panel panelBuscarLab;
        private TextBox txtBuscarLab;
        private Panel panelTabla;
        private DataGridView dgvListaReservas;
        private Label label11;
        private Label label10;
        private Button btnNuevoResv;
        private Button btnGrabarResv;
        private Button btnBuscarResv;
        private Panel panel1;
        private TextBox txtBuscarResv;
        private Panel panel3;
        private Button btnEliminarResv;
        private Panel panelFmrLab;
        private Button button8;
        private Button button3;
        private Panel panel2;
        private Panel panel4;
        private Label label12;
        private DateTimePicker dtpFinal;
        private DateTimePicker dtpInicio;
        private TextBox txtId;
        private BindingSource clReservaBindingSource;
        private DataGridViewTextBoxColumn dgvIdResv;
        private DataGridViewTextBoxColumn dgvDocenteResv;
        private DataGridViewTextBoxColumn dgvAsignaturaResv;
        private DataGridViewTextBoxColumn dgvLaboratorioResv;
        private DataGridViewTextBoxColumn dgvFechaResv;
        private DataGridViewTextBoxColumn dgvHoraInicioResv;
        private DataGridViewTextBoxColumn dgvHoraFinResv;
        private DataGridViewTextBoxColumn dgvCantidadPersonasResv;
        private DataGridViewComboBoxColumn dvgEstado;
    }
}