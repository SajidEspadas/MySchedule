
namespace MySchedule
{
    partial class FrmRecordatorio
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
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblNombreRecordatorio = new System.Windows.Forms.Label();
            this.txtNombreRecordatorio = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.dtpRecordatorio = new System.Windows.Forms.DateTimePicker();
            this.lblAlarma = new System.Windows.Forms.Label();
            this.dtpAlarma = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(33, 48);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.lblFechaInicio.TabIndex = 0;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Enabled = false;
            this.txtFechaInicio.Location = new System.Drawing.Point(126, 45);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(167, 22);
            this.txtFechaInicio.TabIndex = 1;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(422, 48);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(74, 17);
            this.lblFechaFin.TabIndex = 2;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // lblNombreRecordatorio
            // 
            this.lblNombreRecordatorio.AutoSize = true;
            this.lblNombreRecordatorio.Location = new System.Drawing.Point(33, 109);
            this.lblNombreRecordatorio.Name = "lblNombreRecordatorio";
            this.lblNombreRecordatorio.Size = new System.Drawing.Size(167, 17);
            this.lblNombreRecordatorio.TabIndex = 4;
            this.lblNombreRecordatorio.Text = "Nombre del Recordatorio";
            // 
            // txtNombreRecordatorio
            // 
            this.txtNombreRecordatorio.Location = new System.Drawing.Point(225, 106);
            this.txtNombreRecordatorio.Name = "txtNombreRecordatorio";
            this.txtNombreRecordatorio.Size = new System.Drawing.Size(329, 22);
            this.txtNombreRecordatorio.TabIndex = 5;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(33, 169);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(80, 17);
            this.lblComentario.TabIndex = 6;
            this.lblComentario.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(126, 166);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(558, 22);
            this.txtComentario.TabIndex = 7;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(343, 322);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(91, 23);
            this.cmdGuardar.TabIndex = 8;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(470, 322);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(84, 23);
            this.cmdLimpiar.TabIndex = 9;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(587, 322);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(85, 23);
            this.cmdCancelar.TabIndex = 10;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // dtpRecordatorio
            // 
            this.dtpRecordatorio.CustomFormat = "dd/MM/yyyy";
            this.dtpRecordatorio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRecordatorio.Location = new System.Drawing.Point(502, 45);
            this.dtpRecordatorio.Name = "dtpRecordatorio";
            this.dtpRecordatorio.Size = new System.Drawing.Size(273, 22);
            this.dtpRecordatorio.TabIndex = 11;
            // 
            // lblAlarma
            // 
            this.lblAlarma.AutoSize = true;
            this.lblAlarma.Location = new System.Drawing.Point(33, 248);
            this.lblAlarma.Name = "lblAlarma";
            this.lblAlarma.Size = new System.Drawing.Size(52, 17);
            this.lblAlarma.TabIndex = 12;
            this.lblAlarma.Text = "Alarma";
            // 
            // dtpAlarma
            // 
            this.dtpAlarma.CustomFormat = "hh:mm:ss";
            this.dtpAlarma.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAlarma.Location = new System.Drawing.Point(117, 248);
            this.dtpAlarma.Name = "dtpAlarma";
            this.dtpAlarma.Size = new System.Drawing.Size(110, 22);
            this.dtpAlarma.TabIndex = 13;
            // 
            // FrmRecordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 357);
            this.Controls.Add(this.dtpAlarma);
            this.Controls.Add(this.lblAlarma);
            this.Controls.Add(this.dtpRecordatorio);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.txtNombreRecordatorio);
            this.Controls.Add(this.lblNombreRecordatorio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Name = "FrmRecordatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recordatorio";
            this.Load += new System.EventHandler(this.FrmRecordatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblNombreRecordatorio;
        private System.Windows.Forms.TextBox txtNombreRecordatorio;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.DateTimePicker dtpRecordatorio;
        private System.Windows.Forms.Label lblAlarma;
        private System.Windows.Forms.DateTimePicker dtpAlarma;
    }
}