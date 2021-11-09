using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

using System.Runtime.InteropServices;
using Dominio;






namespace Presentation
{
    public partial class frmLogin : Form
    {


        frmCrearCuenta frmCrearCuenta = new frmCrearCuenta();


        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

           






        }





        #region Controles Formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barNav_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void BarNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void btnMinimizeLogin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }




        #endregion

        #region Eventos Textbox Formulario


        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                lblUsuarioLog.Visible = true;
                txtUser.ForeColor = Color.LightGray;

            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {

            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                lblUsuarioLog.Visible = false;
                txtUser.ForeColor = Color.DimGray;

            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {




            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                lblContraseñaLog.Visible = true;
                txtPassword.ForeColor = Color.LightGray;
                MostrarPassword();




            }
        }


        private void txtPassword_Leave(object sender, EventArgs e)
        {


            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                lblContraseñaLog.Visible = false;
                txtPassword.ForeColor = Color.DimGray;

                OcultarPassword();


            }

        }


        #region Mostrar y Ocultar Contraseña

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            OcultarPassword();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarPassword();
        }




        private void MostrarPassword()
        {
            btnOcultar.TabStop = false;
            if (txtPassword.PasswordChar == '\0')
            {
                btnOcultar.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
        private void OcultarPassword()
        {
            btnMostrar.TabStop = false;

            if (txtPassword.PasswordChar == '*')
            {
                btnMostrar.BringToFront();
                txtPassword.PasswordChar = '\0';
            }

        }


        #endregion

        #endregion

        private void lblCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        
            frmCrearCuenta.Show();



        }

        public void btnLogin_Click(object sender, EventArgs e)
        {


       
            if(txtUser.Text != "USERNAME")
            {
                if(txtPassword.Text != "Password")
                {
                    ModeloUsuario cargarUsuario = new ModeloUsuario();
                    var loginValido = cargarUsuario.LoginUsuario(txtUser.Text, txtPassword.Text);
                    if(loginValido == true)
                    {
                        frmConfiirmacionLogin frmConfiirmacionLogin = new frmConfiirmacionLogin();
                        frmConfiirmacionLogin.lblBienvenido.Text = txtUser.Text;
                        frmConfiirmacionLogin.Show();
                        this.Hide();
                    }
                }






            }

     
           

           

            
            
             




            





        }
        
    }
}