
namespace MySchedule
{
    partial class MySchedule_Login
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.cmdIniciarSesion = new System.Windows.Forms.Button();
            this.PboxMyScheduleLogo = new System.Windows.Forms.PictureBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PboxMyScheduleLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(205, 408);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(96, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID de usuario:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(334, 403);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 22);
            this.txtID.TabIndex = 1;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(205, 450);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(85, 17);
            this.lblContra.TabIndex = 2;
            this.lblContra.Tag = "";
            this.lblContra.Text = "Contraseña:";
            this.lblContra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(334, 445);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(158, 22);
            this.txtContra.TabIndex = 3;
            // 
            // cmdIniciarSesion
            // 
            this.cmdIniciarSesion.Location = new System.Drawing.Point(261, 485);
            this.cmdIniciarSesion.Name = "cmdIniciarSesion";
            this.cmdIniciarSesion.Size = new System.Drawing.Size(119, 26);
            this.cmdIniciarSesion.TabIndex = 4;
            this.cmdIniciarSesion.Text = "Iniciar Sesión";
            this.cmdIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // PboxMyScheduleLogo
            // 
            this.PboxMyScheduleLogo.ImageLocation = "https://www.tijuana.tecnm.mx/wp-content/uploads/2015/01/logo_ITT.png";
            this.PboxMyScheduleLogo.Location = new System.Drawing.Point(157, 93);
            this.PboxMyScheduleLogo.Name = "PboxMyScheduleLogo";
            this.PboxMyScheduleLogo.Size = new System.Drawing.Size(364, 285);
            this.PboxMyScheduleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PboxMyScheduleLogo.TabIndex = 5;
            this.PboxMyScheduleLogo.TabStop = false;
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(549, 605);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(119, 26);
            this.cmdRegistrar.TabIndex = 6;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // MySchedule_Login
            // 
            this.AcceptButton = this.cmdIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 643);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.PboxMyScheduleLogo);
            this.Controls.Add(this.cmdIniciarSesion);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "MySchedule_Login";
            this.Text = "MySchedule - Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.PboxMyScheduleLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button cmdIniciarSesion;
        private System.Windows.Forms.PictureBox PboxMyScheduleLogo;
        private System.Windows.Forms.Button cmdRegistrar;
    }
}

