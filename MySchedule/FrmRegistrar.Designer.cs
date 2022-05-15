
namespace MySchedule
{
    partial class FrmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrar));
            this.PboxMyScheduleLogo = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.pboxCerrar = new System.Windows.Forms.PictureBox();
            this.pboxMinimizar = new System.Windows.Forms.PictureBox();
            this.cboxTermYCond = new System.Windows.Forms.CheckBox();
            this.lblTermYCond = new System.Windows.Forms.LinkLabel();
            this.pnlTermYCond = new System.Windows.Forms.Panel();
            this.lblTermYCondText = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PboxMyScheduleLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMinimizar)).BeginInit();
            this.pnlTermYCond.SuspendLayout();
            this.SuspendLayout();
            // 
            // PboxMyScheduleLogo
            // 
            this.PboxMyScheduleLogo.Image = ((System.Drawing.Image)(resources.GetObject("PboxMyScheduleLogo.Image")));
            this.PboxMyScheduleLogo.ImageLocation = "";
            this.PboxMyScheduleLogo.Location = new System.Drawing.Point(32, 80);
            this.PboxMyScheduleLogo.Name = "PboxMyScheduleLogo";
            this.PboxMyScheduleLogo.Size = new System.Drawing.Size(364, 285);
            this.PboxMyScheduleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PboxMyScheduleLogo.TabIndex = 6;
            this.PboxMyScheduleLogo.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 380);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(164, 375);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(59, 418);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(164, 413);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 22);
            this.txtApellido.TabIndex = 10;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(59, 457);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 17);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(164, 457);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(185, 22);
            this.txtCorreo.TabIndex = 12;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(59, 495);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(85, 17);
            this.lblContraseña.TabIndex = 13;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(164, 492);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 22);
            this.textBox4.TabIndex = 14;
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Enabled = false;
            this.cmdRegistrar.Location = new System.Drawing.Point(135, 536);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(129, 28);
            this.cmdRegistrar.TabIndex = 15;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.Location = new System.Drawing.Point(284, 626);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(129, 28);
            this.cmdCancelar.TabIndex = 18;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // pboxCerrar
            // 
            this.pboxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pboxCerrar.Image")));
            this.pboxCerrar.Location = new System.Drawing.Point(383, 12);
            this.pboxCerrar.Name = "pboxCerrar";
            this.pboxCerrar.Size = new System.Drawing.Size(30, 30);
            this.pboxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCerrar.TabIndex = 17;
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
            this.pboxMinimizar.TabIndex = 19;
            this.pboxMinimizar.TabStop = false;
            this.pboxMinimizar.Click += new System.EventHandler(this.pboxMinimizar_Click);
            // 
            // cboxTermYCond
            // 
            this.cboxTermYCond.AutoSize = true;
            this.cboxTermYCond.Location = new System.Drawing.Point(105, 570);
            this.cboxTermYCond.Name = "cboxTermYCond";
            this.cboxTermYCond.Size = new System.Drawing.Size(18, 17);
            this.cboxTermYCond.TabIndex = 16;
            this.cboxTermYCond.UseVisualStyleBackColor = true;
            // 
            // lblTermYCond
            // 
            this.lblTermYCond.AutoSize = true;
            this.lblTermYCond.Location = new System.Drawing.Point(129, 570);
            this.lblTermYCond.Name = "lblTermYCond";
            this.lblTermYCond.Size = new System.Drawing.Size(157, 17);
            this.lblTermYCond.TabIndex = 17;
            this.lblTermYCond.TabStop = true;
            this.lblTermYCond.Text = "Términos y condiciones";
            this.lblTermYCond.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTermYCond_LinkClicked);
            // 
            // pnlTermYCond
            // 
            this.pnlTermYCond.AutoScroll = true;
            this.pnlTermYCond.Controls.Add(this.lblTermYCondText);
            this.pnlTermYCond.Location = new System.Drawing.Point(12, 48);
            this.pnlTermYCond.Name = "pnlTermYCond";
            this.pnlTermYCond.Size = new System.Drawing.Size(401, 562);
            this.pnlTermYCond.TabIndex = 20;
            this.pnlTermYCond.Visible = false;
            // 
            // lblTermYCondText
            // 
            this.lblTermYCondText.AutoEllipsis = true;
            this.lblTermYCondText.AutoSize = true;
            this.lblTermYCondText.Location = new System.Drawing.Point(3, 0);
            this.lblTermYCondText.Name = "lblTermYCondText";
            this.lblTermYCondText.Size = new System.Drawing.Size(731, 2992);
            this.lblTermYCondText.TabIndex = 0;
            this.lblTermYCondText.Text = resources.GetString("lblTermYCondText.Text");
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCerrar.Location = new System.Drawing.Point(284, 626);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(129, 28);
            this.cmdCerrar.TabIndex = 21;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Visible = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // FrmRegistrar
            // 
            this.AcceptButton = this.cmdRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(425, 666);
            this.Controls.Add(this.pnlTermYCond);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lblTermYCond);
            this.Controls.Add(this.cboxTermYCond);
            this.Controls.Add(this.pboxMinimizar);
            this.Controls.Add(this.pboxCerrar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.PboxMyScheduleLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySchedule - Registrar";
            ((System.ComponentModel.ISupportInitialize)(this.PboxMyScheduleLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMinimizar)).EndInit();
            this.pnlTermYCond.ResumeLayout(false);
            this.pnlTermYCond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PboxMyScheduleLogo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.PictureBox pboxCerrar;
        private System.Windows.Forms.PictureBox pboxMinimizar;
        private System.Windows.Forms.CheckBox cboxTermYCond;
        private System.Windows.Forms.LinkLabel lblTermYCond;
        private System.Windows.Forms.Panel pnlTermYCond;
        private System.Windows.Forms.Label lblTermYCondText;
        private System.Windows.Forms.Button cmdCerrar;
    }
}