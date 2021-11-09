
namespace Presentation
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.lblContraseñaLog = new System.Windows.Forms.Label();
            this.lblUsuarioLog = new System.Windows.Forms.Label();
            this.lblConstraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnMostrar = new FontAwesome.Sharp.IconButton();
            this.btnOcultar = new FontAwesome.Sharp.IconButton();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lineC = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.line = new System.Windows.Forms.Panel();
            this.barNav = new System.Windows.Forms.Panel();
            this.btnMinimizeLogin = new FontAwesome.Sharp.IconButton();
            this.btnCloseLogin = new FontAwesome.Sharp.IconButton();
            this.Main.SuspendLayout();
            this.barNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Malgun Gothic Semilight", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(119, 298);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogin.Size = new System.Drawing.Size(331, 39);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblUser.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.SlateGray;
            this.lblUser.Location = new System.Drawing.Point(163, 46);
            this.lblUser.Margin = new System.Windows.Forms.Padding(0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(226, 41);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "LOGIN";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-5, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 423);
            this.panel2.TabIndex = 4;
            // 
            // Main
            // 
            this.Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Main.Controls.Add(this.lblContraseñaLog);
            this.Main.Controls.Add(this.lblUsuarioLog);
            this.Main.Controls.Add(this.lblConstraseña);
            this.Main.Controls.Add(this.lblUsuario);
            this.Main.Controls.Add(this.btnMostrar);
            this.Main.Controls.Add(this.btnOcultar);
            this.Main.Controls.Add(this.linkLabel2);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.lblCrearCuenta);
            this.Main.Controls.Add(this.txtPassword);
            this.Main.Controls.Add(this.lineC);
            this.Main.Controls.Add(this.txtUser);
            this.Main.Controls.Add(this.line);
            this.Main.Controls.Add(this.lblUser);
            this.Main.Controls.Add(this.btnLogin);
            this.Main.Location = new System.Drawing.Point(280, 40);
            this.Main.Margin = new System.Windows.Forms.Padding(0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(583, 423);
            this.Main.TabIndex = 1;
            // 
            // lblContraseñaLog
            // 
            this.lblContraseñaLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraseñaLog.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11F);
            this.lblContraseñaLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContraseñaLog.Location = new System.Drawing.Point(68, 191);
            this.lblContraseñaLog.Margin = new System.Windows.Forms.Padding(0);
            this.lblContraseñaLog.Name = "lblContraseñaLog";
            this.lblContraseñaLog.Size = new System.Drawing.Size(106, 25);
            this.lblContraseñaLog.TabIndex = 20;
            this.lblContraseñaLog.Text = "CONTRASEÑA";
            this.lblContraseñaLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContraseñaLog.Visible = false;
            // 
            // lblUsuarioLog
            // 
            this.lblUsuarioLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioLog.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11F);
            this.lblUsuarioLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuarioLog.Location = new System.Drawing.Point(67, 110);
            this.lblUsuarioLog.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsuarioLog.Name = "lblUsuarioLog";
            this.lblUsuarioLog.Size = new System.Drawing.Size(74, 25);
            this.lblUsuarioLog.TabIndex = 19;
            this.lblUsuarioLog.Text = "USUARIO";
            this.lblUsuarioLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuarioLog.Visible = false;
            // 
            // lblConstraseña
            // 
            this.lblConstraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConstraseña.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11F);
            this.lblConstraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConstraseña.Location = new System.Drawing.Point(66, 192);
            this.lblConstraseña.Margin = new System.Windows.Forms.Padding(0);
            this.lblConstraseña.Name = "lblConstraseña";
            this.lblConstraseña.Size = new System.Drawing.Size(0, 0);
            this.lblConstraseña.TabIndex = 18;
            this.lblConstraseña.Text = "CONTRASEÑA";
            this.lblConstraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConstraseña.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11F);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(68, 113);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 0);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.Text = "USUARIO";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.Visible = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.CausesValidation = false;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnMostrar.IconColor = System.Drawing.Color.DimGray;
            this.btnMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrar.IconSize = 24;
            this.btnMostrar.Location = new System.Drawing.Point(458, 223);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(24, 15);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.TabStop = false;
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultar.FlatAppearance.BorderSize = 0;
            this.btnOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultar.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnOcultar.IconColor = System.Drawing.Color.DimGray;
            this.btnOcultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOcultar.IconSize = 24;
            this.btnOcultar.Location = new System.Drawing.Point(458, 223);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(24, 15);
            this.btnOcultar.TabIndex = 11;
            this.btnOcultar.TabStop = false;
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.linkLabel2.Location = new System.Drawing.Point(197, 378);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(154, 18);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "¿Ha Olvidado su Contraseña?";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Gray;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(138, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "¿Ya tienes una Cuenta?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblCrearCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCrearCuenta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblCrearCuenta.Location = new System.Drawing.Point(273, 348);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(92, 24);
            this.lblCrearCuenta.TabIndex = 8;
            this.lblCrearCuenta.TabStop = true;
            this.lblCrearCuenta.Text = "Crea tu Cuenta";
            this.lblCrearCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCrearCuenta.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lblCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCrearCuenta_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPassword.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(70, 219);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(420, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "CONTRASEÑA";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lineC
            // 
            this.lineC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lineC.Enabled = false;
            this.lineC.Location = new System.Drawing.Point(72, 240);
            this.lineC.Name = "lineC";
            this.lineC.Size = new System.Drawing.Size(410, 3);
            this.lineC.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUser.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11F);
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(70, 139);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(412, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.TabStop = false;
            this.txtUser.Text = "USUARIO";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line.Location = new System.Drawing.Point(72, 161);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(410, 3);
            this.line.TabIndex = 4;
            // 
            // barNav
            // 
            this.barNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.barNav.Controls.Add(this.btnMinimizeLogin);
            this.barNav.Controls.Add(this.btnCloseLogin);
            this.barNav.Location = new System.Drawing.Point(-2, -1);
            this.barNav.Name = "barNav";
            this.barNav.Size = new System.Drawing.Size(865, 41);
            this.barNav.TabIndex = 17;
            this.barNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barNav_MouseDown_1);
            // 
            // btnMinimizeLogin
            // 
            this.btnMinimizeLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeLogin.FlatAppearance.BorderSize = 0;
            this.btnMinimizeLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnMinimizeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeLogin.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnMinimizeLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimizeLogin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizeLogin.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinimizeLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizeLogin.IconSize = 32;
            this.btnMinimizeLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizeLogin.Location = new System.Drawing.Point(784, 1);
            this.btnMinimizeLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizeLogin.Name = "btnMinimizeLogin";
            this.btnMinimizeLogin.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnMinimizeLogin.Size = new System.Drawing.Size(38, 38);
            this.btnMinimizeLogin.TabIndex = 17;
            this.btnMinimizeLogin.TabStop = false;
            this.btnMinimizeLogin.UseVisualStyleBackColor = true;
            this.btnMinimizeLogin.Click += new System.EventHandler(this.btnMinimizeLogin_Click);
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseLogin.FlatAppearance.BorderSize = 0;
            this.btnCloseLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLogin.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnCloseLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCloseLogin.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCloseLogin.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseLogin.IconSize = 32;
            this.btnCloseLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseLogin.Location = new System.Drawing.Point(822, 2);
            this.btnCloseLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnCloseLogin.Size = new System.Drawing.Size(43, 38);
            this.btnCloseLogin.TabIndex = 15;
            this.btnCloseLogin.TabStop = false;
            this.btnCloseLogin.UseVisualStyleBackColor = true;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 462);
            this.Controls.Add(this.barNav);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Main);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.barNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel barNav;
        private FontAwesome.Sharp.IconButton btnMinimizeLogin;
        private FontAwesome.Sharp.IconButton btnCloseLogin;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel lineC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblCrearCuenta;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private FontAwesome.Sharp.IconButton btnOcultar;
        private FontAwesome.Sharp.IconButton btnMostrar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConstraseña;
        private System.Windows.Forms.Label lblUsuarioLog;
        private System.Windows.Forms.Label lblContraseñaLog;
        private System.Windows.Forms.TextBox txtUser;
    }
}

