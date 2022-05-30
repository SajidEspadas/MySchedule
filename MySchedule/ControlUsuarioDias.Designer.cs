
namespace MySchedule
{
    partial class ControlUsuarioDias
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblRecordatorio = new System.Windows.Forms.Label();
            this.TimerRecord = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(3, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(24, 17);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "00";
            // 
            // lblRecordatorio
            // 
            this.lblRecordatorio.Location = new System.Drawing.Point(6, 42);
            this.lblRecordatorio.Name = "lblRecordatorio";
            this.lblRecordatorio.Size = new System.Drawing.Size(156, 44);
            this.lblRecordatorio.TabIndex = 1;
            this.lblRecordatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerRecord
            // 
            this.TimerRecord.Tick += new System.EventHandler(this.TimerRecord_Tick);
            // 
            // ControlUsuarioDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRecordatorio);
            this.Controls.Add(this.lblDias);
            this.Name = "ControlUsuarioDias";
            this.Size = new System.Drawing.Size(165, 86);
            this.Click += new System.EventHandler(this.ControlUsuarioDias_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblRecordatorio;
        private System.Windows.Forms.Timer TimerRecord;
    }
}
