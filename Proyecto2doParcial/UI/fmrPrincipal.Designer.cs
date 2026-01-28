namespace CapaPresentacion.UI
{
    partial class FmrPrincipal : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrPrincipal));
            panelMenu = new Panel();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnReservas = new FontAwesome.Sharp.IconButton();
            btnLaboratorios = new FontAwesome.Sharp.IconButton();
            PanelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            btnMax = new FontAwesome.Sharp.IconButton();
            btnMinus = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelSombra = new Panel();
            panelDesktop = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(12, 43, 78);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnReservas);
            panelMenu.Controls.Add(btnLaboratorios);
            panelMenu.Controls.Add(PanelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(236, 691);
            panelMenu.TabIndex = 0;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btnReportes.IconColor = Color.White;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 32;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 320);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(10, 0, 20, 0);
            btnReportes.Size = new Size(236, 60);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnReservas
            // 
            btnReservas.Dock = DockStyle.Top;
            btnReservas.FlatAppearance.BorderSize = 0;
            btnReservas.FlatStyle = FlatStyle.Flat;
            btnReservas.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservas.ForeColor = Color.White;
            btnReservas.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            btnReservas.IconColor = Color.White;
            btnReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReservas.IconSize = 32;
            btnReservas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservas.Location = new Point(0, 260);
            btnReservas.Name = "btnReservas";
            btnReservas.Padding = new Padding(10, 0, 20, 0);
            btnReservas.Size = new Size(236, 60);
            btnReservas.TabIndex = 2;
            btnReservas.Text = "Reservas";
            btnReservas.TextAlign = ContentAlignment.MiddleLeft;
            btnReservas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReservas.UseVisualStyleBackColor = true;
            btnReservas.Click += btnReservas_Click;
            // 
            // btnLaboratorios
            // 
            btnLaboratorios.Dock = DockStyle.Top;
            btnLaboratorios.FlatAppearance.BorderSize = 0;
            btnLaboratorios.FlatStyle = FlatStyle.Flat;
            btnLaboratorios.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLaboratorios.ForeColor = Color.White;
            btnLaboratorios.IconChar = FontAwesome.Sharp.IconChar.Computer;
            btnLaboratorios.IconColor = Color.White;
            btnLaboratorios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLaboratorios.IconSize = 32;
            btnLaboratorios.ImageAlign = ContentAlignment.MiddleLeft;
            btnLaboratorios.Location = new Point(0, 200);
            btnLaboratorios.Name = "btnLaboratorios";
            btnLaboratorios.Padding = new Padding(10, 0, 20, 0);
            btnLaboratorios.Size = new Size(236, 60);
            btnLaboratorios.TabIndex = 1;
            btnLaboratorios.Text = "Laboratorios";
            btnLaboratorios.TextAlign = ContentAlignment.MiddleLeft;
            btnLaboratorios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLaboratorios.UseVisualStyleBackColor = true;
            btnLaboratorios.Click += btnLaboratorios_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.Controls.Add(btnHome);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Padding = new Padding(10, 0, 20, 0);
            PanelLogo.Size = new Size(236, 200);
            PanelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(30, 66);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(170, 81);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 61, 100);
            panelTitleBar.Controls.Add(btnMax);
            panelTitleBar.Controls.Add(btnMinus);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.ForeColor = SystemColors.Control;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1098, 86);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.FromArgb(26, 61, 100);
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.ForeColor = Color.FromArgb(26, 61, 100);
            btnMax.IconChar = FontAwesome.Sharp.IconChar.Square;
            btnMax.IconColor = Color.White;
            btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMax.IconSize = 22;
            btnMax.Location = new Point(1042, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(29, 29);
            btnMax.TabIndex = 3;
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnMinus
            // 
            btnMinus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinus.BackColor = Color.FromArgb(26, 61, 100);
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.ForeColor = Color.FromArgb(26, 61, 100);
            btnMinus.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnMinus.IconColor = Color.White;
            btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinus.IconSize = 22;
            btnMinus.Location = new Point(1014, 0);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(29, 29);
            btnMinus.TabIndex = 2;
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(26, 61, 100);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.FromArgb(26, 61, 100);
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnExit.IconColor = Color.White;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 22;
            btnExit.Location = new Point(1069, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 29);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = Color.White;
            lblTitleChildForm.Location = new Point(71, 34);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(62, 24);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(26, 61, 100);
            iconCurrentChildForm.ForeColor = Color.FromArgb(45, 107, 176);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.FromArgb(45, 107, 176);
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 50;
            iconCurrentChildForm.Location = new Point(19, 19);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(50, 51);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelSombra
            // 
            panelSombra.BackColor = Color.FromArgb(39, 67, 100);
            panelSombra.Dock = DockStyle.Top;
            panelSombra.Location = new Point(0, 86);
            panelSombra.Name = "panelSombra";
            panelSombra.Size = new Size(1098, 9);
            panelSombra.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Controls.Add(label1);
            panelDesktop.Controls.Add(panelSombra);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Controls.Add(panelTitleBar);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(236, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1098, 691);
            panelDesktop.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(224, 427);
            label1.Name = "label1";
            label1.Size = new Size(644, 42);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Reservas de Laboratorios";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(367, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FmrPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1334, 691);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            Name = "FmrPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            panelMenu.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel PanelLogo;
        private FontAwesome.Sharp.IconButton btnLaboratorios;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnReservas;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelSombra;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnMinus;
        private Label label1;
    }
}
