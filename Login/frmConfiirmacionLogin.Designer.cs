
namespace Presentation
{
    partial class frmConfiirmacionLogin
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new CircularProgressBar.CircularProgressBar();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.MainConfirm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.MainConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar1.AnimationSpeed = 500;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.progressBar1.InnerMargin = 2;
            this.progressBar1.InnerWidth = -1;
            this.progressBar1.Location = new System.Drawing.Point(574, 178);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.MarqueeAnimationSpeed = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.progressBar1.OuterMargin = -25;
            this.progressBar1.OuterWidth = 25;
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.progressBar1.ProgressWidth = 20;
            this.progressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.progressBar1.Size = new System.Drawing.Size(150, 150);
            this.progressBar1.StartAngle = 270;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar1.SubscriptMargin = new System.Windows.Forms.Padding(3, -32, 0, 0);
            this.progressBar1.SubscriptText = "%";
            this.progressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar1.SuperscriptText = "";
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Text = "0";
            this.progressBar1.TextMargin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.progressBar1.Value = 68;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.BarraSuperior.Location = new System.Drawing.Point(-1, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1043, 67);
            this.BarraSuperior.TabIndex = 1;
            // 
            // MainConfirm
            // 
            this.MainConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.MainConfirm.Controls.Add(this.label1);
            this.MainConfirm.Controls.Add(this.panel1);
            this.MainConfirm.Controls.Add(this.lblBienvenido);
            this.MainConfirm.Controls.Add(this.progressBar1);
            this.MainConfirm.Location = new System.Drawing.Point(-1, 66);
            this.MainConfirm.Name = "MainConfirm";
            this.MainConfirm.Size = new System.Drawing.Size(1043, 460);
            this.MainConfirm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(398, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 70);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(0, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 467);
            this.panel1.TabIndex = 2;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Font = new System.Drawing.Font("Malgun Gothic Semilight", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBienvenido.Location = new System.Drawing.Point(710, 35);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(253, 59);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmConfiirmacionLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 524);
            this.Controls.Add(this.MainConfirm);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfiirmacionLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfiirmacionLogin";
            this.Load += new System.EventHandler(this.frmConfiirmacionLogin_Load);
            this.MainConfirm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar progressBar1;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Panel MainConfirm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
    }
}