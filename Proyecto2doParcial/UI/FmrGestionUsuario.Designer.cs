namespace CapaPresentacion.UI
{
    partial class FmrGestionUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrGestionUsuario));
            panelFmrGestionUsu = new Panel();
            btnEliminarUsuario = new Button();
            btnRegistrarUsuario = new Button();
            panelTabla = new Panel();
            label11 = new Label();
            dgvGestionUsuarios = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            contraseñaUsu = new DataGridViewTextBoxColumn();
            btnModificarUsuario = new Button();
            panelBuscarUsuario = new Panel();
            txtBuscarUsuario = new TextBox();
            label4 = new Label();
            panelConten = new Panel();
            panelCampoContraseña = new Panel();
            txtContraseña = new TextBox();
            panelCampoUsuario = new Panel();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            btnBuscarUsuario = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panelFmrGestionUsu.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionUsuarios).BeginInit();
            panelBuscarUsuario.SuspendLayout();
            panelConten.SuspendLayout();
            panelCampoContraseña.SuspendLayout();
            panelCampoUsuario.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelFmrGestionUsu
            // 
            panelFmrGestionUsu.Anchor = AnchorStyles.None;
            panelFmrGestionUsu.BackColor = Color.White;
            panelFmrGestionUsu.Controls.Add(btnEliminarUsuario);
            panelFmrGestionUsu.Controls.Add(btnRegistrarUsuario);
            panelFmrGestionUsu.Controls.Add(panelTabla);
            panelFmrGestionUsu.Controls.Add(btnModificarUsuario);
            panelFmrGestionUsu.Controls.Add(panelBuscarUsuario);
            panelFmrGestionUsu.Controls.Add(label4);
            panelFmrGestionUsu.Controls.Add(panelConten);
            panelFmrGestionUsu.Controls.Add(panel2);
            panelFmrGestionUsu.Controls.Add(panel1);
            panelFmrGestionUsu.Controls.Add(btnBuscarUsuario);
            panelFmrGestionUsu.Controls.Add(pictureBox1);
            panelFmrGestionUsu.Controls.Add(label3);
            panelFmrGestionUsu.Location = new Point(-2, -1);
            panelFmrGestionUsu.Name = "panelFmrGestionUsu";
            panelFmrGestionUsu.Size = new Size(1103, 598);
            panelFmrGestionUsu.TabIndex = 8;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarUsuario.BackColor = Color.FromArgb(0, 57, 108);
            btnEliminarUsuario.Cursor = Cursors.Hand;
            btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            btnEliminarUsuario.FlatStyle = FlatStyle.Flat;
            btnEliminarUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarUsuario.ForeColor = Color.White;
            btnEliminarUsuario.Location = new Point(283, 504);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(114, 33);
            btnEliminarUsuario.TabIndex = 23;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrarUsuario.BackColor = Color.FromArgb(0, 57, 108);
            btnRegistrarUsuario.Cursor = Cursors.Hand;
            btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            btnRegistrarUsuario.FlatStyle = FlatStyle.Flat;
            btnRegistrarUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarUsuario.ForeColor = Color.White;
            btnRegistrarUsuario.Location = new Point(26, 504);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(114, 33);
            btnRegistrarUsuario.TabIndex = 21;
            btnRegistrarUsuario.Text = "Registrar";
            btnRegistrarUsuario.UseVisualStyleBackColor = false;
            // 
            // panelTabla
            // 
            panelTabla.AccessibleRole = AccessibleRole.None;
            panelTabla.BackColor = Color.FromArgb(242, 248, 255);
            panelTabla.Controls.Add(label11);
            panelTabla.Controls.Add(dgvGestionUsuarios);
            panelTabla.Location = new Point(449, 199);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(630, 338);
            panelTabla.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(242, 248, 255);
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(0, 57, 108);
            label11.Location = new Point(246, 12);
            label11.Name = "label11";
            label11.Size = new Size(132, 19);
            label11.TabIndex = 35;
            label11.Text = "Lista de Usuarios";
            // 
            // dgvGestionUsuarios
            // 
            dgvGestionUsuarios.AllowUserToAddRows = false;
            dgvGestionUsuarios.AllowUserToDeleteRows = false;
            dgvGestionUsuarios.AllowUserToResizeColumns = false;
            dgvGestionUsuarios.AllowUserToResizeRows = false;
            dgvGestionUsuarios.Anchor = AnchorStyles.Top;
            dgvGestionUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestionUsuarios.BackgroundColor = Color.FromArgb(242, 248, 255);
            dgvGestionUsuarios.BorderStyle = BorderStyle.None;
            dgvGestionUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvGestionUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGestionUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGestionUsuarios.ColumnHeadersHeight = 43;
            dgvGestionUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGestionUsuarios.Columns.AddRange(new DataGridViewColumn[] { Usuario, contraseñaUsu });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(242, 248, 255);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGestionUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGestionUsuarios.EnableHeadersVisualStyles = false;
            dgvGestionUsuarios.GridColor = Color.FromArgb(0, 57, 108);
            dgvGestionUsuarios.Location = new Point(16, 36);
            dgvGestionUsuarios.Name = "dgvGestionUsuarios";
            dgvGestionUsuarios.ReadOnly = true;
            dgvGestionUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 57, 108);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvGestionUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(242, 248, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvGestionUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvGestionUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionUsuarios.ShowCellToolTips = false;
            dgvGestionUsuarios.ShowEditingIcon = false;
            dgvGestionUsuarios.Size = new Size(602, 282);
            dgvGestionUsuarios.TabIndex = 0;
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "Usuario";
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuario.DefaultCellStyle = dataGridViewCellStyle2;
            Usuario.FillWeight = 200F;
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 20;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // contraseñaUsu
            // 
            contraseñaUsu.DataPropertyName = "contraseña";
            contraseñaUsu.FillWeight = 200F;
            contraseñaUsu.HeaderText = "Constraseña";
            contraseñaUsu.MinimumWidth = 20;
            contraseñaUsu.Name = "contraseñaUsu";
            contraseñaUsu.ReadOnly = true;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificarUsuario.BackColor = Color.FromArgb(0, 57, 108);
            btnModificarUsuario.Cursor = Cursors.Hand;
            btnModificarUsuario.FlatAppearance.BorderSize = 0;
            btnModificarUsuario.FlatStyle = FlatStyle.Flat;
            btnModificarUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarUsuario.ForeColor = Color.White;
            btnModificarUsuario.Location = new Point(157, 504);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(114, 33);
            btnModificarUsuario.TabIndex = 7;
            btnModificarUsuario.Text = "Modificar";
            btnModificarUsuario.UseVisualStyleBackColor = false;
            // 
            // panelBuscarUsuario
            // 
            panelBuscarUsuario.BackColor = Color.FromArgb(242, 248, 255);
            panelBuscarUsuario.Controls.Add(txtBuscarUsuario);
            panelBuscarUsuario.Location = new Point(580, 155);
            panelBuscarUsuario.Name = "panelBuscarUsuario";
            panelBuscarUsuario.Size = new Size(499, 33);
            panelBuscarUsuario.TabIndex = 18;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarUsuario.BackColor = Color.FromArgb(242, 248, 255);
            txtBuscarUsuario.BorderStyle = BorderStyle.None;
            txtBuscarUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarUsuario.ForeColor = Color.Gray;
            txtBuscarUsuario.Location = new Point(14, 6);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(473, 20);
            txtBuscarUsuario.TabIndex = 13;
            txtBuscarUsuario.Text = "Buscar Usuario...";
            txtBuscarUsuario.Enter += txtBuscarUsuario_Enter;
            txtBuscarUsuario.Leave += txtBuscarUsuario_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 57, 108);
            label4.Location = new Point(26, 154);
            label4.Name = "label4";
            label4.Size = new Size(288, 23);
            label4.TabIndex = 17;
            label4.Text = "Formulario Registro de Usuario";
            // 
            // panelConten
            // 
            panelConten.BackColor = Color.FromArgb(242, 248, 255);
            panelConten.Controls.Add(panelCampoContraseña);
            panelConten.Controls.Add(panelCampoUsuario);
            panelConten.Controls.Add(label1);
            panelConten.Controls.Add(label2);
            panelConten.Location = new Point(26, 199);
            panelConten.Name = "panelConten";
            panelConten.Size = new Size(371, 267);
            panelConten.TabIndex = 16;
            // 
            // panelCampoContraseña
            // 
            panelCampoContraseña.BackColor = Color.FromArgb(213, 232, 255);
            panelCampoContraseña.Controls.Add(txtContraseña);
            panelCampoContraseña.Location = new Point(17, 178);
            panelCampoContraseña.Name = "panelCampoContraseña";
            panelCampoContraseña.Size = new Size(332, 36);
            panelCampoContraseña.TabIndex = 18;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(213, 232, 255);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(17, 9);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(297, 20);
            txtContraseña.TabIndex = 4;
            // 
            // panelCampoUsuario
            // 
            panelCampoUsuario.BackColor = Color.FromArgb(213, 232, 255);
            panelCampoUsuario.Controls.Add(txtUsuario);
            panelCampoUsuario.Location = new Point(17, 77);
            panelCampoUsuario.Name = "panelCampoUsuario";
            panelCampoUsuario.Size = new Size(332, 36);
            panelCampoUsuario.TabIndex = 17;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(213, 232, 255);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(15, 8);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(299, 20);
            txtUsuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 248, 255);
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 39);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 248, 255);
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 137);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 3;
            label2.Text = "Constraseña:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 235, 235);
            panel2.Location = new Point(424, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 350);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(27, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 3);
            panel1.TabIndex = 14;
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
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.FromArgb(0, 57, 108);
            btnBuscarUsuario.Cursor = Cursors.Hand;
            btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            btnBuscarUsuario.FlatStyle = FlatStyle.Flat;
            btnBuscarUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarUsuario.ForeColor = Color.White;
            btnBuscarUsuario.Location = new Point(449, 154);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(114, 33);
            btnBuscarUsuario.TabIndex = 12;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = false;
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
            label3.Size = new Size(469, 57);
            label3.TabIndex = 10;
            label3.Text = "Gestión de Usuarios";
            // 
            // FmrGestionUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 597);
            Controls.Add(panelFmrGestionUsu);
            Name = "FmrGestionUsuario";
            Text = "FmrCuentas";
            panelFmrGestionUsu.ResumeLayout(false);
            panelFmrGestionUsu.PerformLayout();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionUsuarios).EndInit();
            panelBuscarUsuario.ResumeLayout(false);
            panelBuscarUsuario.PerformLayout();
            panelConten.ResumeLayout(false);
            panelConten.PerformLayout();
            panelCampoContraseña.ResumeLayout(false);
            panelCampoContraseña.PerformLayout();
            panelCampoUsuario.ResumeLayout(false);
            panelCampoUsuario.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFmrGestionUsu;
        private Button btnEliminarUsuario;
        private Button btnRegistrarUsuario;
        private Panel panelTabla;
        private Label label11;
        private DataGridView dgvGestionUsuarios;
        private Button btnModificarUsuario;
        private Panel panelBuscarUsuario;
        private TextBox txtBuscarUsuario;
        private Label label4;
        private Panel panelConten;
        private Panel panelCampoContraseña;
        private TextBox txtContraseña;
        private Panel panelCampoUsuario;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private Button btnBuscarUsuario;
        private PictureBox pictureBox1;
        private Label label3;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn contraseñaUsu;
    }
}