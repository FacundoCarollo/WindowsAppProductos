using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using FontAwesome.Sharp;
using Dominio;
using Common.Cache;








namespace Presentation
{
    public partial class frmInicio : Form
    {
       
        private IconButton ActualBtn;
        private Panel BordeBtn;
        private Form ActualFormHijo;
       




        public frmInicio()
        {
            InitializeComponent();

            BordeBtn = new Panel();
            BordeBtn.Size = new Size(5, 41);
            barNav.Controls.Add(BordeBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;








        }

       


        private void Form1_Load(object sender, EventArgs e)
        {


            CargarDatosInicio();
            
            
            
           


        }


        #region Colores

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }



        #endregion


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                //Button
                ActualBtn = (IconButton)senderBtn;
                ActualBtn.BackColor = Color.FromArgb(26, 32, 40);
                ActualBtn.ForeColor = color;
                ActualBtn.TextAlign = ContentAlignment.MiddleCenter;
                ActualBtn.IconColor = color;
                ActualBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                ActualBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                BordeBtn.BackColor = color;
                BordeBtn.Location = new Point(0, ActualBtn.Location.Y);
                BordeBtn.Visible = true;
                BordeBtn.BringToFront();


            }
        }



        private void CargarDatosInicio()
        {
            lblPositionicio.Text = UserCache.Position;
            lblEmailInicio.Text = UserCache.Email;
            lblUserInicio.Text = UserCache.Username;

        }

        private void DesactivarBoton()
        {
            if (ActualBtn != null)
            {
                ActualBtn.BackColor = Color.FromArgb(26, 32, 40 );
                ActualBtn.ForeColor = Color.Gainsboro;
                ActualBtn.TextAlign = ContentAlignment.MiddleLeft;
                ActualBtn.IconColor = Color.Gainsboro;
                ActualBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                ActualBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void AbrirFormHijo(Form FormHijo)
        {
            //open only form
            if (ActualFormHijo != null)
            {
                ActualFormHijo.Close();
            }

            ActualFormHijo = FormHijo;
            //End
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            Main.Controls.Add(FormHijo);
            Main.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
         
        }

        



        private void Resetear()
        {
            DesactivarBoton();
           
        }




        #region Controles Formulario


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarNav_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void BtnClose_Click(object sender, EventArgs e)
        {
            Cierre();
        }


        public void BtnMaximize_Click(object sender, EventArgs e)
        {
            Maximizacion();
        }

        public void BtnMinimize_Click(object sender, EventArgs e)
        {
            Minimizacion();
          
        }




        public void Maximizacion()
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        public void Minimizacion()
        {

            WindowState = FormWindowState.Minimized;

        }

        public void Cierre()
        {
            Application.Exit();

        }





        #endregion

       

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFormHijo(new frmProductos());

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (ActualFormHijo != null)
            {
               ActualFormHijo .Close();
            }
            Resetear();

            ActivateButton(sender, RGBColors.color2);


            
        }

      

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirFormHijo(new frmSettings());

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            AbrirFormHijo(new frmSettings());
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
          
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("¿Desea cerrar la sesión?", "Alert", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
                frmLogin frm = new frmLogin();
                frm.Show();
                
            }
            
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailInicio_Click(object sender, EventArgs e)
        {

        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
