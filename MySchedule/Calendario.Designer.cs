
namespace MySchedule
{
    partial class Calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRecordatorio = new System.Windows.Forms.Button();
            this.btnComentario = new System.Windows.Forms.Button();
            this.PicReloj = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicReloj)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(757, 59);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem,
            this.horariosToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.tareasToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(101, 590);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menú";
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
            // btnRecordatorio
            // 
            this.btnRecordatorio.Location = new System.Drawing.Point(366, 39);
            this.btnRecordatorio.Name = "btnRecordatorio";
            this.btnRecordatorio.Size = new System.Drawing.Size(183, 29);
            this.btnRecordatorio.TabIndex = 2;
            this.btnRecordatorio.Text = "Agregar Recordatorio";
            this.btnRecordatorio.UseVisualStyleBackColor = true;
            this.btnRecordatorio.Click += new System.EventHandler(this.btnRecordatorio_Click);
            // 
            // btnComentario
            // 
            this.btnComentario.Location = new System.Drawing.Point(366, 126);
            this.btnComentario.Name = "btnComentario";
            this.btnComentario.Size = new System.Drawing.Size(183, 29);
            this.btnComentario.TabIndex = 3;
            this.btnComentario.Text = "Agregar Comentario";
            this.btnComentario.UseVisualStyleBackColor = true;
            // 
            // PicReloj
            // 
            this.PicReloj.Image = ((System.Drawing.Image)(resources.GetObject("PicReloj.Image")));
            this.PicReloj.Location = new System.Drawing.Point(342, 202);
            this.PicReloj.Name = "PicReloj";
            this.PicReloj.Size = new System.Drawing.Size(230, 208);
            this.PicReloj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicReloj.TabIndex = 4;
            this.PicReloj.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(339, 446);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(43, 17);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora:";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(488, 446);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(61, 17);
            this.lblMinutos.TabIndex = 6;
            this.lblMinutos.Text = "Minutos:";
            this.lblMinutos.Click += new System.EventHandler(this.lblMinutos_Click);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(388, 443);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(62, 22);
            this.txtHora.TabIndex = 7;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(555, 443);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(62, 22);
            this.txtMinutos.TabIndex = 8;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 590);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.PicReloj);
            this.Controls.Add(this.btnComentario);
            this.Controls.Add(this.btnRecordatorio);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicReloj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.Button btnRecordatorio;
        private System.Windows.Forms.Button btnComentario;
        private System.Windows.Forms.PictureBox PicReloj;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtMinutos;
    }
}