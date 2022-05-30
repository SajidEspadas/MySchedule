
namespace MySchedule
{
    partial class FrmCalendario
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
            this.MenuSchedule = new System.Windows.Forms.MenuStrip();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContenedorDias = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDomingo = new System.Windows.Forms.Label();
            this.lblLunes = new System.Windows.Forms.Label();
            this.lblMartes = new System.Windows.Forms.Label();
            this.lblMiercoles = new System.Windows.Forms.Label();
            this.lblJueves = new System.Windows.Forms.Label();
            this.lblViernes = new System.Windows.Forms.Label();
            this.lblSabado = new System.Windows.Forms.Label();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.lblMesAño = new System.Windows.Forms.Label();
            this.MenuSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuSchedule
            // 
            this.MenuSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuSchedule.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuSchedule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem,
            this.horariosToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.tareasToolStripMenuItem});
            this.MenuSchedule.Location = new System.Drawing.Point(0, 0);
            this.MenuSchedule.Name = "MenuSchedule";
            this.MenuSchedule.Size = new System.Drawing.Size(101, 673);
            this.MenuSchedule.TabIndex = 0;
            this.MenuSchedule.Text = "Menu";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // horariosToolStripMenuItem
            // 
            this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            this.horariosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.horariosToolStripMenuItem.Text = "Horarios";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // ContenedorDias
            // 
            this.ContenedorDias.Location = new System.Drawing.Point(170, 110);
            this.ContenedorDias.Name = "ContenedorDias";
            this.ContenedorDias.Size = new System.Drawing.Size(1198, 558);
            this.ContenedorDias.TabIndex = 1;
            // 
            // lblDomingo
            // 
            this.lblDomingo.AutoSize = true;
            this.lblDomingo.Location = new System.Drawing.Point(224, 90);
            this.lblDomingo.Name = "lblDomingo";
            this.lblDomingo.Size = new System.Drawing.Size(64, 17);
            this.lblDomingo.TabIndex = 2;
            this.lblDomingo.Text = "Domingo";
            // 
            // lblLunes
            // 
            this.lblLunes.AutoSize = true;
            this.lblLunes.Location = new System.Drawing.Point(400, 90);
            this.lblLunes.Name = "lblLunes";
            this.lblLunes.Size = new System.Drawing.Size(47, 17);
            this.lblLunes.TabIndex = 3;
            this.lblLunes.Text = "Lunes";
            // 
            // lblMartes
            // 
            this.lblMartes.AutoSize = true;
            this.lblMartes.Location = new System.Drawing.Point(572, 90);
            this.lblMartes.Name = "lblMartes";
            this.lblMartes.Size = new System.Drawing.Size(51, 17);
            this.lblMartes.TabIndex = 4;
            this.lblMartes.Text = "Martes";
            // 
            // lblMiercoles
            // 
            this.lblMiercoles.AutoSize = true;
            this.lblMiercoles.Location = new System.Drawing.Point(742, 90);
            this.lblMiercoles.Name = "lblMiercoles";
            this.lblMiercoles.Size = new System.Drawing.Size(68, 17);
            this.lblMiercoles.TabIndex = 5;
            this.lblMiercoles.Text = "Miercoles";
            // 
            // lblJueves
            // 
            this.lblJueves.AutoSize = true;
            this.lblJueves.Location = new System.Drawing.Point(917, 90);
            this.lblJueves.Name = "lblJueves";
            this.lblJueves.Size = new System.Drawing.Size(53, 17);
            this.lblJueves.TabIndex = 6;
            this.lblJueves.Text = "Jueves";
            // 
            // lblViernes
            // 
            this.lblViernes.AutoSize = true;
            this.lblViernes.Location = new System.Drawing.Point(1083, 90);
            this.lblViernes.Name = "lblViernes";
            this.lblViernes.Size = new System.Drawing.Size(56, 17);
            this.lblViernes.TabIndex = 7;
            this.lblViernes.Text = "Viernes";
            // 
            // lblSabado
            // 
            this.lblSabado.AutoSize = true;
            this.lblSabado.Location = new System.Drawing.Point(1257, 90);
            this.lblSabado.Name = "lblSabado";
            this.lblSabado.Size = new System.Drawing.Size(57, 17);
            this.lblSabado.TabIndex = 8;
            this.lblSabado.Text = "Sabado";
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Location = new System.Drawing.Point(430, 39);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(88, 23);
            this.cmdAnterior.TabIndex = 9;
            this.cmdAnterior.Text = "Anterior";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Location = new System.Drawing.Point(973, 39);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(82, 23);
            this.cmdSiguiente.TabIndex = 10;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // lblMesAño
            // 
            this.lblMesAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAño.Location = new System.Drawing.Point(535, 33);
            this.lblMesAño.Name = "lblMesAño";
            this.lblMesAño.Size = new System.Drawing.Size(411, 29);
            this.lblMesAño.TabIndex = 11;
            this.lblMesAño.Text = "MES AÑO";
            this.lblMesAño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 673);
            this.Controls.Add(this.lblMesAño);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.lblSabado);
            this.Controls.Add(this.lblViernes);
            this.Controls.Add(this.lblJueves);
            this.Controls.Add(this.lblMiercoles);
            this.Controls.Add(this.lblMartes);
            this.Controls.Add(this.lblLunes);
            this.Controls.Add(this.lblDomingo);
            this.Controls.Add(this.ContenedorDias);
            this.Controls.Add(this.MenuSchedule);
            this.MainMenuStrip = this.MenuSchedule;
            this.Name = "FrmCalendario";
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.FrmCalendario_Load);
            this.MenuSchedule.ResumeLayout(false);
            this.MenuSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuSchedule;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel ContenedorDias;
        private System.Windows.Forms.Label lblDomingo;
        private System.Windows.Forms.Label lblLunes;
        private System.Windows.Forms.Label lblMartes;
        private System.Windows.Forms.Label lblMiercoles;
        private System.Windows.Forms.Label lblJueves;
        private System.Windows.Forms.Label lblViernes;
        private System.Windows.Forms.Label lblSabado;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Label lblMesAño;
    }
}