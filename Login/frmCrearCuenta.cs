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
    public partial class frmCrearCuenta : Form 
    {
        public frmCrearCuenta()
        {
            InitializeComponent();
        }





        #region Cerrar y Minimizar Formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barNav_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        private void btnMinimizeLogin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCloseCrearCuenta_Click(object sender, EventArgs e)
        {
            
        }


        #endregion

        #region Eventos texbox Formulario

        private void txtEmail_Enter(object sender, EventArgs e)
        {

            if (txtEmail.Text == "EMAIL")
            {
                
                txtEmail.Text = "";
                lblEmail.Visible = true;
                txtEmail.ForeColor = Color.LightGray;

            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

            if (txtEmail.Text == "")
            {
                
                txtEmail.Text = "EMAIL";
                lblEmail.Visible = false;
                txtEmail.ForeColor = Color.DimGray;

            }

        }

        private void txtUser_Enter_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {

               
                txtUser.Text = "";
                lblUsuario.Visible = true;
                txtUser.ForeColor = Color.LightGray;

            }
        }

        private void txtUser_Leave_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {

                txtUser.Text = "USUARIO";
                lblUsuario.Visible = false;
                txtUser.ForeColor = Color.DimGray;

            }
        }

        private void txtPassword_Enter_1(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                lblConstraseña.Visible = true;
                txtPassword.ForeColor = Color.LightGray;
                MostrarPassword();




            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                lblConstraseña.Visible = false;
                txtPassword.ForeColor = Color.DimGray;

                OcultarPassword();


            }
        }

        #region Mostrar y ocultar Contraseña


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarPassword();

        }


        private void btnOcultar_Click(object sender, EventArgs e)
        {
            OcultarPassword();

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


     
       private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       {

           frmLogin frmLogin = new frmLogin();
           frmLogin.Show();
           this.Hide();

       }

       private void txtUser_TextChanged(object sender, EventArgs e)
       {

       }

       private void txtEmail_TextChanged(object sender, EventArgs e)
       {

       }

       private void lblUser_Click(object sender, EventArgs e)
       {

       }

      

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {

            if (txtUser.Text != "USERNAME")
            {
                if (txtPassword.Text != "Password")
                {
                    ModeloUsuario nuevo = new ModeloUsuario();
                    var nuevoUserValido = nuevo.NuevoUser(txtEmail.Text, txtUser.Text, txtPassword.Text);

                    if (nuevoUserValido >=1)
                    {
                        MessageBox.Show("Cuenta creada con exito");
                        this.Hide();
                    }
                }




            }


        }

        private void lblLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
