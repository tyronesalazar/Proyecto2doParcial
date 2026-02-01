using APPreservaLabUI.UI;
using FontAwesome.Sharp;
using CapaLogicaNegocio.LogicaNegocio;
using System.Runtime.InteropServices;
namespace CapaPresentacion.UI
{
    public partial class FmrPrincipal : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private Cl_LN_Laboratorio ln_laboratorio = new Cl_LN_Laboratorio();
        private Cl_LN_Reserva ln_reserva = new Cl_LN_Reserva();
        private Cl_LN_Reportes ln_Reportes = new Cl_LN_Reportes();

        private Form currentChildForm;
        FmrLaboratorios formularioLab;
        FmrReportes formularioRep;
        FmrReservas formularioRes;
        //Constructor
        public FmrPrincipal()
        {
            formularioLab = new FmrLaboratorios(ln_laboratorio);
            formularioRep = new FmrReportes(ln_Reportes, ln_reserva, ln_laboratorio);
            formularioRes = new FmrReservas(ln_laboratorio, ln_reserva);

            InitializeComponent();
            //Barra lateral (indicador)
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Eliminar Barra superior
            this.Text = string.Empty;
            this.ControlBox = false;
            //interfaz fluida
            this.DoubleBuffered = true;
            //Delimitar a la pantalla max del escritorio
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        //Estructura Colores botones
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(152, 172, 248);
            public static Color color2 = Color.FromArgb(255, 184, 224);
            public static Color color3 = Color.FromArgb(247, 141, 96);

        }
        //Métodos
        //Resaltar el botón activo
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Personalización botón
                currentBtn = (IconButton)senderBtn;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Borde izq Botón
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Home
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        //Desactivar el resaltado de botón
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Abrir formulario hijo
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //Solo se abre 1 formulario
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

        }
        private void btnLaboratorios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(formularioLab);
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(formularioRes);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(formularioRep);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Hide();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(45, 107, 176);
            lblTitleChildForm.Text = "Inicio";
        }

        //Mover formulario mediante evento mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
