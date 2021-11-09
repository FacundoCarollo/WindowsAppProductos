
namespace Presentation
{
    partial class frmCrearCuenta
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
            this.barNav = new System.Windows.Forms.Panel();
            this.btnMinimizeCrearCuenta = new FontAwesome.Sharp.IconButton();
            this.btnCloseCrearCuenta = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConstraseña = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnMostrar = new FontAwesome.Sharp.IconButton();
            this.btnOcultar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lineC = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.line = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.barNav.SuspendLayout();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // barNav
            // 
            this.barNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.barNav.Controls.Add(this.btnMinimizeCrearCuenta);
            this.barNav.Controls.Add(this.btnCloseCrearCuenta);
            this.barNav.Location = new System.Drawing.Point(-84, 0);
            this.barNav.Name = "barNav";
            this.barNav.Size = new System.Drawing.Size(955, 38);
            this.barNav.TabIndex = 18;
            this.barNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barNav_MouseDown);
            // 
            // btnMinimizeCrearCuenta
            // 
            this.btnMinimizeCrearCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeCrearCuenta.FlatAppearance.BorderSize = 0;
            this.btnMinimizeCrearCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnMinimizeCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeCrearCuenta.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnMinimizeCrearCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimizeCrearCuenta.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizeCrearCuenta.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinimizeCrearCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizeCrearCuenta.IconSize = 32;
            this.btnMinimizeCrearCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizeCrearCuenta.Location = new System.Drawing.Point(874, 0);
            this.btnMinimizeCrearCuenta.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizeCrearCuenta.Name = "btnMinimizeCrearCuenta";
            this.btnMinimizeCrearCuenta.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnMinimizeCrearCuenta.Size = new System.Drawing.Size(38, 38);
            this.btnMinimizeCrearCuenta.TabIndex = 17;
            this.btnMinimizeCrearCuenta.TabStop = false;
            this.btnMinimizeCrearCuenta.UseVisualStyleBackColor = true;
            this.btnMinimizeCrearCuenta.Click += new System.EventHandler(this.btnMinimizeLogin_Click);
            // 
            // btnCloseCrearCuenta
            // 
            this.btnCloseCrearCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseCrearCuenta.FlatAppearance.BorderSize = 0;
            this.btnCloseCrearCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCloseCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCrearCuenta.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnCloseCrearCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCloseCrearCuenta.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCloseCrearCuenta.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseCrearCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseCrearCuenta.IconSize = 32;
            this.btnCloseCrearCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseCrearCuenta.Location = new System.Drawing.Point(912, 0);
            this.btnCloseCrearCuenta.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseCrearCuenta.Name = "btnCloseCrearCuenta";
            this.btnCloseCrearCuenta.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnCloseCrearCuenta.Size = new System.Drawing.Size(43, 38);
            this.btnCloseCrearCuenta.TabIndex = 15;
            this.btnCloseCrearCuenta.TabStop = false;
            this.btnCloseCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCloseCrearCuenta.Click += new System.EventHandler(this.btnCloseCrearCuenta_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-1, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 425);
            this.panel2.TabIndex = 19;
            // 
            // Main
            // 
            this.Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Main.Controls.Add(this.lblUsuario);
            this.Main.Controls.Add(this.lblConstraseña);
            this.Main.Controls.Add(this.lblEmail);
            this.Main.Controls.Add(this.panel1);
            this.Main.Controls.Add(this.txtEmail);
            this.Main.Controls.Add(this.btnMostrar);
            this.Main.Controls.Add(this.btnOcultar);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.lblLogin);
            this.Main.Controls.Add(this.txtPassword);
            this.Main.Controls.Add(this.lineC);
            this.Main.Controls.Add(this.txtUser);
            this.Main.Controls.Add(this.line);
            this.Main.Controls.Add(this.lblUser);
            this.Main.Controls.Add(this.btnCrearCuenta);
            this.Main.Location = new System.Drawing.Point(278, 37);
            this.Main.Margin = new System.Windows.Forms.Padding(0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(593, 425);
            this.Main.TabIndex = 20;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11F);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(66, 174);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 25);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "USUARIO";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.Visible = false;
            // 
            // lblConstraseña
            // 
            this.lblConstraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConstraseña.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11F);
            this.lblConstraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConstraseña.Location = new System.Drawing.Point(68, 243);
            this.lblConstraseña.Margin = new System.Windows.Forms.Padding(0);
            this.lblConstraseña.Name = "lblConstraseña";
            this.lblConstraseña.Size = new System.Drawing.Size(106, 25);
            this.lblConstraseña.TabIndex = 15;
            this.lblConstraseña.Text = "CONTRASEÑA";
            this.lblConstraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConstraseña.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11F);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(66, 99);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 25);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "EMAIL";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmail.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(73, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 3);
            this.panel1.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmail.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(72, 127);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(420, 20);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TabStop = false;
            this.txtEmail.Text = "EMAIL";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
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
            this.btnMostrar.Location = new System.Drawing.Point(457, 276);
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
            this.btnOcultar.Location = new System.Drawing.Point(459, 276);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(24, 15);
            this.btnOcultar.TabIndex = 11;
            this.btnOcultar.TabStop = false;
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(186, 373);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "¿Ya tienes una Cuenta?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblLogin.Location = new System.Drawing.Point(333, 380);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(98, 24);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.TabStop = true;
            this.lblLogin.Text = "Inicia tu Sesion";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.VisitedLinkColor = System.Drawing.Color.Gray;
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
            this.txtPassword.Location = new System.Drawing.Point(70, 272);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(420, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "CONTRASEÑA";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter_1);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lineC
            // 
            this.lineC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lineC.Enabled = false;
            this.lineC.Location = new System.Drawing.Point(72, 294);
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
            this.txtUser.Location = new System.Drawing.Point(70, 200);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(413, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.TabStop = false;
            this.txtUser.Text = "USUARIO";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter_1);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave_1);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line.Location = new System.Drawing.Point(72, 222);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(410, 3);
            this.line.TabIndex = 4;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblUser.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.SlateGray;
            this.lblUser.Location = new System.Drawing.Point(175, 33);
            this.lblUser.Margin = new System.Windows.Forms.Padding(0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(226, 41);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Registrarse";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCrearCuenta.FlatAppearance.BorderSize = 0;
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Malgun Gothic Semilight", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearCuenta.Location = new System.Drawing.Point(123, 324);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCrearCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrearCuenta.Size = new System.Drawing.Size(331, 39);
            this.btnCrearCuenta.TabIndex = 0;
            this.btnCrearCuenta.TabStop = false;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // frmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 462);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearCuenta";
            this.Text = "frmCrearCuenta";
            this.barNav.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barNav;
        private FontAwesome.Sharp.IconButton btnMinimizeCrearCuenta;
        private FontAwesome.Sharp.IconButton btnCloseCrearCuenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Main;
        private FontAwesome.Sharp.IconButton btnMostrar;
        private FontAwesome.Sharp.IconButton btnOcultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel lineC;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConstraseña;
        private System.Windows.Forms.Label lblEmail;
    }
}