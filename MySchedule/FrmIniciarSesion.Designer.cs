
namespace MySchedule
{
    partial class FrmIniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIniciarSesion));
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmdIniciarSesion = new System.Windows.Forms.Button();
            this.PboxMyScheduleLogo = new System.Windows.Forms.PictureBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.pboxCerrar = new System.Windows.Forms.PictureBox();
            this.pboxMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PboxMyScheduleLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(80, 421);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 17);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(209, 416);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(158, 22);
            this.txtCorreo.TabIndex = 1;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(80, 463);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(85, 17);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Tag = "";
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(209, 458);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(158, 22);
            this.txtContraseña.TabIndex = 3;
            // 
            // cmdIniciarSesion
            // 
            this.cmdIniciarSesion.Location = new System.Drawing.Point(158, 496);
            this.cmdIniciarSesion.Name = "cmdIniciarSesion";
            this.cmdIniciarSesion.Size = new System.Drawing.Size(119, 26);
            this.cmdIniciarSesion.TabIndex = 4;
            this.cmdIniciarSesion.Text = "Iniciar Sesión";
            this.cmdIniciarSesion.UseVisualStyleBackColor = true;
            this.cmdIniciarSesion.Click += new System.EventHandler(this.cmdIniciarSesion_Click);
            // 
            // PboxMyScheduleLogo
            // 
            this.PboxMyScheduleLogo.Image = ((System.Drawing.Image)(resources.GetObject("PboxMyScheduleLogo.Image")));
            this.PboxMyScheduleLogo.ImageLocation = "";
            this.PboxMyScheduleLogo.Location = new System.Drawing.Point(32, 80);
            this.PboxMyScheduleLogo.Name = "PboxMyScheduleLogo";
            this.PboxMyScheduleLogo.Size = new System.Drawing.Size(364, 285);
            this.PboxMyScheduleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PboxMyScheduleLogo.TabIndex = 5;
            this.PboxMyScheduleLogo.TabStop = false;
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(294, 628);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(119, 26);
            this.cmdRegistrar.TabIndex = 6;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // pboxCerrar
            // 
            this.pboxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pboxCerrar.Image")));
            this.pboxCerrar.Location = new System.Drawing.Point(383, 12);
            this.pboxCerrar.Name = "pboxCerrar";
            this.pboxCerrar.Size = new System.Drawing.Size(30, 30);
            this.pboxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCerrar.TabIndex = 18;
            this.pboxCerrar.TabStop = false;
            this.pboxCerrar.Click += new System.EventHandler(this.pboxCerrar_Click);
            // 
            // pboxMinimizar
            // 
            this.pboxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pboxMinimizar.Image")));
            this.pboxMinimizar.Location = new System.Drawing.Point(347, 12);
            this.pboxMinimizar.Name = "pboxMinimizar";
            this.pboxMinimizar.Size = new System.Drawing.Size(30, 30);
            this.pboxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMinimizar.TabIndex = 20;
            this.pboxMinimizar.TabStop = false;
            this.pboxMinimizar.Click += new System.EventHandler(this.pboxMinimizar_Click);
            // 
            // FrmIniciarSesion
            // 
            this.AcceptButton = this.cmdIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 666);
            this.Controls.Add(this.pboxMinimizar);
            this.Controls.Add(this.pboxCerrar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.PboxMyScheduleLogo);
            this.Controls.Add(this.cmdIniciarSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySchedule - Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.PboxMyScheduleLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button cmdIniciarSesion;
        private System.Windows.Forms.PictureBox PboxMyScheduleLogo;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.PictureBox pboxCerrar;
        private System.Windows.Forms.PictureBox pboxMinimizar;
    }
}

