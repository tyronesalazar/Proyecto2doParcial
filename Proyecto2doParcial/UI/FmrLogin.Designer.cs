namespace CapaPresentacion.UI
{
    partial class FmrLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrLogin));
            panelFmrLogin = new Panel();
            txtContraseñaUsu = new TextBox();
            txtCedulaUsu = new TextBox();
            btnRegistrarse = new Button();
            btnIniciarSesion = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelFmrLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelFmrLogin
            // 
            panelFmrLogin.BackColor = Color.White;
            panelFmrLogin.Controls.Add(txtContraseñaUsu);
            panelFmrLogin.Controls.Add(txtCedulaUsu);
            panelFmrLogin.Controls.Add(btnRegistrarse);
            panelFmrLogin.Controls.Add(btnIniciarSesion);
            panelFmrLogin.Controls.Add(panel2);
            panelFmrLogin.Controls.Add(pictureBox3);
            panelFmrLogin.Controls.Add(panel1);
            panelFmrLogin.Controls.Add(label4);
            panelFmrLogin.Controls.Add(pictureBox2);
            panelFmrLogin.Controls.Add(pictureBox1);
            panelFmrLogin.Location = new Point(0, 0);
            panelFmrLogin.Name = "panelFmrLogin";
            panelFmrLogin.Size = new Size(464, 606);
            panelFmrLogin.TabIndex = 0;
            // 
            // txtContraseñaUsu
            // 
            txtContraseñaUsu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtContraseñaUsu.BackColor = Color.White;
            txtContraseñaUsu.BorderStyle = BorderStyle.None;
            txtContraseñaUsu.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseñaUsu.ForeColor = Color.Gray;
            txtContraseñaUsu.Location = new Point(114, 383);
            txtContraseñaUsu.Name = "txtContraseñaUsu";
            txtContraseñaUsu.Size = new Size(282, 24);
            txtContraseñaUsu.TabIndex = 27;
            txtContraseñaUsu.Text = "Contraseña...";
            txtContraseñaUsu.Enter += txtContraseñaUsu_Enter;
            txtContraseñaUsu.Leave += txtContraseñaUsu_Leave;
            // 
            // txtCedulaUsu
            // 
            txtCedulaUsu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCedulaUsu.BackColor = Color.White;
            txtCedulaUsu.BorderStyle = BorderStyle.None;
            txtCedulaUsu.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedulaUsu.ForeColor = Color.Gray;
            txtCedulaUsu.Location = new Point(114, 302);
            txtCedulaUsu.Name = "txtCedulaUsu";
            txtCedulaUsu.Size = new Size(282, 24);
            txtCedulaUsu.TabIndex = 26;
            txtCedulaUsu.Text = "Cedula...";
            txtCedulaUsu.Enter += txtCedulaUsu_Enter;
            txtCedulaUsu.Leave += txtCedulaUsu_Leave;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrarse.BackColor = Color.White;
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnRegistrarse.ForeColor = Color.FromArgb(0, 57, 108);
            btnRegistrarse.Location = new Point(180, 512);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(103, 33);
            btnRegistrarse.TabIndex = 25;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIniciarSesion.BackColor = Color.FromArgb(0, 57, 108);
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(146, 473);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(170, 33);
            btnIniciarSesion.TabIndex = 24;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 57, 108);
            panel2.Location = new Point(51, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(364, 3);
            panel2.TabIndex = 21;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(51, 369);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 57, 108);
            panel1.Location = new Point(51, 332);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 3);
            panel1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 57, 108);
            label4.Location = new Point(50, 216);
            label4.Name = "label4";
            label4.Size = new Size(374, 25);
            label4.TabIndex = 18;
            label4.Text = "Sistema De Reservas De Laboratorio";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(114, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(231, 170);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 288);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FmrLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 605);
            Controls.Add(panelFmrLogin);
            Name = "FmrLogin";
            Text = "FmrLogin";
            panelFmrLogin.ResumeLayout(false);
            panelFmrLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFmrLogin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button btnIniciarSesion;
        private Button btnRegistrarse;
        private TextBox txtCedulaUsu;
        private TextBox txtContraseñaUsu;
    }
}