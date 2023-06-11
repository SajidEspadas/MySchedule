
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrar));
            this.PboxMyScheduleLogo = new System.Windows.Forms.PictureBox();
            this.cboxTermYCond = new System.Windows.Forms.CheckBox();
            this.lblTermYCond = new System.Windows.Forms.LinkLabel();
            this.pnlTermYCond = new System.Windows.Forms.Panel();
            this.lblTermYCondText = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.ktxtNombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtApellido = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtCorreo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtContraseña = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kcmdRegistrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcmdCerrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcmdCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PaletaModoOscuro = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.PaletaModoClaro = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PboxMyScheduleLogo)).BeginInit();
            this.pnlTermYCond.SuspendLayout();
            this.SuspendLayout();
            // 
            // PboxMyScheduleLogo
            // 
            this.PboxMyScheduleLogo.Image = ((System.Drawing.Image)(resources.GetObject("PboxMyScheduleLogo.Image")));
            this.PboxMyScheduleLogo.ImageLocation = "";
            this.PboxMyScheduleLogo.Location = new System.Drawing.Point(54, 12);
            this.PboxMyScheduleLogo.Name = "PboxMyScheduleLogo";
            this.PboxMyScheduleLogo.Size = new System.Drawing.Size(318, 249);
            this.PboxMyScheduleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PboxMyScheduleLogo.TabIndex = 6;
            this.PboxMyScheduleLogo.TabStop = false;
            // 
            // cboxTermYCond
            // 
            this.cboxTermYCond.AutoSize = true;
            this.cboxTermYCond.Location = new System.Drawing.Point(94, 506);
            this.cboxTermYCond.Name = "cboxTermYCond";
            this.cboxTermYCond.Size = new System.Drawing.Size(18, 17);
            this.cboxTermYCond.TabIndex = 7;
            this.cboxTermYCond.UseVisualStyleBackColor = true;
            // 
            // lblTermYCond
            // 
            this.lblTermYCond.AutoSize = true;
            this.lblTermYCond.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermYCond.Location = new System.Drawing.Point(118, 502);
            this.lblTermYCond.Name = "lblTermYCond";
            this.lblTermYCond.Size = new System.Drawing.Size(193, 20);
            this.lblTermYCond.TabIndex = 6;
            this.lblTermYCond.TabStop = true;
            this.lblTermYCond.Text = "Términos y condiciones";
            this.lblTermYCond.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTermYCond_LinkClicked);
            // 
            // pnlTermYCond
            // 
            this.pnlTermYCond.AutoScroll = true;
            this.pnlTermYCond.Controls.Add(this.lblTermYCondText);
            this.pnlTermYCond.Location = new System.Drawing.Point(12, 12);
            this.pnlTermYCond.Name = "pnlTermYCond";
            this.pnlTermYCond.Size = new System.Drawing.Size(398, 526);
            this.pnlTermYCond.TabIndex = 20;
            this.pnlTermYCond.Visible = false;
            // 
            // lblTermYCondText
            // 
            this.lblTermYCondText.AutoEllipsis = true;
            this.lblTermYCondText.AutoSize = true;
            this.lblTermYCondText.Location = new System.Drawing.Point(26, 0);
            this.lblTermYCondText.Name = "lblTermYCondText";
            this.lblTermYCondText.Size = new System.Drawing.Size(334, 3450);
            this.lblTermYCondText.TabIndex = 0;
            this.lblTermYCondText.Text = resources.GetString("lblTermYCondText.Text");
            this.lblTermYCondText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking")));
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking")));
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormRestore.Image")));
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking")));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.InputControlStyles.InputControlStandalone.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.InputControlStyles.InputControlStandalone.StateActive.Border.Rounding = 0;
            // 
            // ktxtNombre
            // 
            this.ktxtNombre.Location = new System.Drawing.Point(54, 267);
            this.ktxtNombre.Name = "ktxtNombre";
            this.ktxtNombre.Size = new System.Drawing.Size(318, 35);
            this.ktxtNombre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxtNombre.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ktxtNombre.StateCommon.Border.Rounding = 20;
            this.ktxtNombre.StateCommon.Border.Width = 1;
            this.ktxtNombre.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.ktxtNombre.StateCommon.Content.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtNombre.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ktxtNombre.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxtNombre.StateNormal.Border.Rounding = 20;
            this.ktxtNombre.StateNormal.Border.Width = 1;
            this.ktxtNombre.TabIndex = 1;
            this.ktxtNombre.Text = "Nombre";
            this.ktxtNombre.Enter += new System.EventHandler(this.ktxtNombre_Enter);
            this.ktxtNombre.Leave += new System.EventHandler(this.ktxtNombre_Leave);
            // 
            // ktxtApellido
            // 
            this.ktxtApellido.Location = new System.Drawing.Point(54, 308);
            this.ktxtApellido.Name = "ktxtApellido";
            this.ktxtApellido.Size = new System.Drawing.Size(318, 35);
            this.ktxtApellido.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxtApellido.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ktxtApellido.StateCommon.Border.Rounding = 20;
            this.ktxtApellido.StateCommon.Border.Width = 1;
            this.ktxtApellido.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.ktxtApellido.StateCommon.Content.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtApellido.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ktxtApellido.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxtApellido.StateNormal.Border.Rounding = 20;
            this.ktxtApellido.StateNormal.Border.Width = 1;
            this.ktxtApellido.TabIndex = 2;
            this.ktxtApellido.Text = "Apellido";
            this.ktxtApellido.Enter += new System.EventHandler(this.ktxtApellido_Enter);
            this.ktxtApellido.Leave += new System.EventHandler(this.ktxtApellido_Leave);
            // 
            // ktxtCorreo
            // 
            this.ktxtCorreo.Location = new System.Drawing.Point(54, 349);
            this.ktxtCorreo.Name = "ktxtCorreo";
            this.ktxtCorreo.Size = new System.Drawing.Size(318, 35);
            this.ktxtCorreo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxtCorreo.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ktxtCorreo.StateCommon.Border.Rounding = 20;
            this.ktxtCorreo.StateCommon.Border.Width = 1;
            this.ktxtCorreo.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.ktxtCorreo.StateCommon.Content.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtCorreo.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ktxtCorreo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxtCorreo.StateNormal.Border.Rounding = 20;
            this.ktxtCorreo.StateNormal.Border.Width = 1;
            this.ktxtCorreo.TabIndex = 3;
            this.ktxtCorreo.Text = "Correo";
            this.ktxtCorreo.Enter += new System.EventHandler(this.ktxtCorreo_Enter);
            this.ktxtCorreo.Leave += new System.EventHandler(this.ktxtCorreo_Leave);
            // 
            // ktxtContraseña
            // 
            this.ktxtContraseña.Location = new System.Drawing.Point(54, 390);
            this.ktxtContraseña.Name = "ktxtContraseña";
            this.ktxtContraseña.Size = new System.Drawing.Size(318, 35);
            this.ktxtContraseña.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxtContraseña.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ktxtContraseña.StateCommon.Border.Rounding = 20;
            this.ktxtContraseña.StateCommon.Border.Width = 1;
            this.ktxtContraseña.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.ktxtContraseña.StateCommon.Content.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtContraseña.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ktxtContraseña.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxtContraseña.StateNormal.Border.Rounding = 20;
            this.ktxtContraseña.StateNormal.Border.Width = 1;
            this.ktxtContraseña.TabIndex = 4;
            this.ktxtContraseña.Text = "Contraseña";
            this.ktxtContraseña.Enter += new System.EventHandler(this.ktxtContraseña_Enter);
            this.ktxtContraseña.Leave += new System.EventHandler(this.ktxtContraseña_Leave);
            // 
            // kcmdRegistrar
            // 
            this.kcmdRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kcmdRegistrar.Location = new System.Drawing.Point(136, 431);
            this.kcmdRegistrar.Name = "kcmdRegistrar";
            this.kcmdRegistrar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdRegistrar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdRegistrar.OverrideDefault.Back.ColorAngle = 45F;
            this.kcmdRegistrar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdRegistrar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdRegistrar.OverrideDefault.Border.ColorAngle = 45F;
            this.kcmdRegistrar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdRegistrar.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdRegistrar.OverrideDefault.Border.Rounding = 20;
            this.kcmdRegistrar.OverrideDefault.Border.Width = 1;
            this.kcmdRegistrar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kcmdRegistrar.Size = new System.Drawing.Size(134, 41);
            this.kcmdRegistrar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdRegistrar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdRegistrar.StateCommon.Back.ColorAngle = 45F;
            this.kcmdRegistrar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdRegistrar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdRegistrar.StateCommon.Border.ColorAngle = 45F;
            this.kcmdRegistrar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdRegistrar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdRegistrar.StateCommon.Border.Rounding = 20;
            this.kcmdRegistrar.StateCommon.Border.Width = 1;
            this.kcmdRegistrar.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kcmdRegistrar.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kcmdRegistrar.StateCommon.Content.LongText.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmdRegistrar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kcmdRegistrar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kcmdRegistrar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmdRegistrar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kcmdRegistrar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kcmdRegistrar.StatePressed.Back.ColorAngle = 135F;
            this.kcmdRegistrar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdRegistrar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kcmdRegistrar.StatePressed.Border.ColorAngle = 135F;
            this.kcmdRegistrar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdRegistrar.StatePressed.Border.Rounding = 20;
            this.kcmdRegistrar.StatePressed.Border.Width = 1;
            this.kcmdRegistrar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdRegistrar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdRegistrar.StateTracking.Back.ColorAngle = 45F;
            this.kcmdRegistrar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdRegistrar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdRegistrar.StateTracking.Border.ColorAngle = 45F;
            this.kcmdRegistrar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdRegistrar.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdRegistrar.StateTracking.Border.Rounding = 20;
            this.kcmdRegistrar.StateTracking.Border.Width = 1;
            this.kcmdRegistrar.TabIndex = 5;
            this.kcmdRegistrar.Values.Text = "Registrar";
            this.kcmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // kcmdCerrar
            // 
            this.kcmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kcmdCerrar.Location = new System.Drawing.Point(276, 544);
            this.kcmdCerrar.Name = "kcmdCerrar";
            this.kcmdCerrar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdCerrar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdCerrar.OverrideDefault.Back.ColorAngle = 45F;
            this.kcmdCerrar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCerrar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCerrar.OverrideDefault.Border.ColorAngle = 45F;
            this.kcmdCerrar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdCerrar.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdCerrar.OverrideDefault.Border.Rounding = 20;
            this.kcmdCerrar.OverrideDefault.Border.Width = 1;
            this.kcmdCerrar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kcmdCerrar.Size = new System.Drawing.Size(134, 41);
            this.kcmdCerrar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdCerrar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdCerrar.StateCommon.Back.ColorAngle = 45F;
            this.kcmdCerrar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdCerrar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCerrar.StateCommon.Border.ColorAngle = 45F;
            this.kcmdCerrar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdCerrar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdCerrar.StateCommon.Border.Rounding = 20;
            this.kcmdCerrar.StateCommon.Border.Width = 1;
            this.kcmdCerrar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCerrar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmdCerrar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kcmdCerrar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kcmdCerrar.StatePressed.Back.ColorAngle = 135F;
            this.kcmdCerrar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdCerrar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kcmdCerrar.StatePressed.Border.ColorAngle = 135F;
            this.kcmdCerrar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdCerrar.StatePressed.Border.Rounding = 20;
            this.kcmdCerrar.StatePressed.Border.Width = 1;
            this.kcmdCerrar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kcmdCerrar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCerrar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdCerrar.StateTracking.Back.ColorAngle = 45F;
            this.kcmdCerrar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdCerrar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCerrar.StateTracking.Border.ColorAngle = 45F;
            this.kcmdCerrar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdCerrar.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdCerrar.StateTracking.Border.Rounding = 20;
            this.kcmdCerrar.StateTracking.Border.Width = 1;
            this.kcmdCerrar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kcmdCerrar.TabIndex = 9;
            this.kcmdCerrar.Values.Text = "Cerrar";
            this.kcmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // kcmdCancelar
            // 
            this.kcmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kcmdCancelar.Location = new System.Drawing.Point(276, 544);
            this.kcmdCancelar.Name = "kcmdCancelar";
            this.kcmdCancelar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdCancelar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdCancelar.OverrideDefault.Back.ColorAngle = 45F;
            this.kcmdCancelar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCancelar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCancelar.OverrideDefault.Border.ColorAngle = 45F;
            this.kcmdCancelar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdCancelar.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdCancelar.OverrideDefault.Border.Rounding = 20;
            this.kcmdCancelar.OverrideDefault.Border.Width = 1;
            this.kcmdCancelar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kcmdCancelar.Size = new System.Drawing.Size(134, 41);
            this.kcmdCancelar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdCancelar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdCancelar.StateCommon.Back.ColorAngle = 45F;
            this.kcmdCancelar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdCancelar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCancelar.StateCommon.Border.ColorAngle = 45F;
            this.kcmdCancelar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdCancelar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdCancelar.StateCommon.Border.Rounding = 20;
            this.kcmdCancelar.StateCommon.Border.Width = 1;
            this.kcmdCancelar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCancelar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmdCancelar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kcmdCancelar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kcmdCancelar.StatePressed.Back.ColorAngle = 135F;
            this.kcmdCancelar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdCancelar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kcmdCancelar.StatePressed.Border.ColorAngle = 135F;
            this.kcmdCancelar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdCancelar.StatePressed.Border.Rounding = 20;
            this.kcmdCancelar.StatePressed.Border.Width = 1;
            this.kcmdCancelar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kcmdCancelar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCancelar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdCancelar.StateTracking.Back.ColorAngle = 45F;
            this.kcmdCancelar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdCancelar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdCancelar.StateTracking.Border.ColorAngle = 45F;
            this.kcmdCancelar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdCancelar.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdCancelar.StateTracking.Border.Rounding = 20;
            this.kcmdCancelar.StateTracking.Border.Width = 1;
            this.kcmdCancelar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kcmdCancelar.TabIndex = 8;
            this.kcmdCancelar.Values.Text = "Cancelar";
            this.kcmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // PaletaModoOscuro
            // 
            this.PaletaModoOscuro.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.PaletaModoOscuro.BaseRenderMode = ComponentFactory.Krypton.Toolkit.RendererMode.Sparkle;
            this.PaletaModoOscuro.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormClose.Image")));
            this.PaletaModoOscuro.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this.PaletaModoOscuro.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this.PaletaModoOscuro.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormMax.Image")));
            this.PaletaModoOscuro.ButtonSpecs.FormMax.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormMax.ImageStates.ImagePressed")));
            this.PaletaModoOscuro.ButtonSpecs.FormMax.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormMax.ImageStates.ImageTracking")));
            this.PaletaModoOscuro.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormMin.Image")));
            this.PaletaModoOscuro.ButtonSpecs.FormMin.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormMin.ImageStates.ImagePressed")));
            this.PaletaModoOscuro.ButtonSpecs.FormMin.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormMin.ImageStates.ImageTracking")));
            this.PaletaModoOscuro.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormRestore.Image")));
            this.PaletaModoOscuro.ButtonSpecs.FormRestore.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormRestore.ImageStates.ImagePressed")));
            this.PaletaModoOscuro.ButtonSpecs.FormRestore.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("PaletaModoOscuro.ButtonSpecs.FormRestore.ImageStates.ImageTracking")));
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoOscuro.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.PaletaModoOscuro.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoOscuro.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.PaletaModoOscuro.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoOscuro.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.PaletaModoOscuro.Cargo.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.Cargo.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.Common.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.Common.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ControlStyles.ControlGroupBox.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ControlStyles.ControlGroupBox.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ControlStyles.ControlGroupBox.StateNormal.Back.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.ControlStyles.ControlGroupBox.StateNormal.Back.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoOscuro.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PaletaModoOscuro.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.PaletaModoOscuro.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.GridStyles.GridCommon.StateCommon.Background.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.GridStyles.GridCommon.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.PaletaModoOscuro.GridStyles.GridCommon.StateNormal.Background.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.GridStyles.GridCommon.StateNormal.Background.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.PaletaModoOscuro.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.PaletaModoOscuro.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.PaletaModoOscuro.InputControlStyles.InputControlStandalone.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoOscuro.InputControlStyles.InputControlStandalone.StateActive.Border.Rounding = 0;
            this.PaletaModoOscuro.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelAlternate.StateCommon.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelAlternate.StateNormal.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelAlternate.StateNormal.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelClient.StateCommon.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelClient.StateNormal.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelClient.StateNormal.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelCommon.StateCommon.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelCommon.StateNormal.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelCommon.StateNormal.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelCustom1.StateCommon.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelCustom1.StateCommon.Color2 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelCustom1.StateNormal.Color1 = System.Drawing.Color.DimGray;
            this.PaletaModoOscuro.PanelStyles.PanelCustom1.StateNormal.Color2 = System.Drawing.Color.DimGray;
            // 
            // PaletaModoClaro
            // 
            this.PaletaModoClaro.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.PaletaModoClaro.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormClose.Image")));
            this.PaletaModoClaro.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this.PaletaModoClaro.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this.PaletaModoClaro.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormMax.Image")));
            this.PaletaModoClaro.ButtonSpecs.FormMax.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormMax.ImageStates.ImagePressed")));
            this.PaletaModoClaro.ButtonSpecs.FormMax.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormMax.ImageStates.ImageTracking")));
            this.PaletaModoClaro.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormMin.Image")));
            this.PaletaModoClaro.ButtonSpecs.FormMin.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormMin.ImageStates.ImagePressed")));
            this.PaletaModoClaro.ButtonSpecs.FormMin.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormMin.ImageStates.ImageTracking")));
            this.PaletaModoClaro.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormRestore.Image")));
            this.PaletaModoClaro.ButtonSpecs.FormRestore.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormRestore.ImageStates.ImagePressed")));
            this.PaletaModoClaro.ButtonSpecs.FormRestore.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("PaletaModoClaro.ButtonSpecs.FormRestore.ImageStates.ImageTracking")));
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoClaro.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.PaletaModoClaro.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoClaro.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.PaletaModoClaro.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoClaro.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.PaletaModoClaro.Cargo.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.Cargo.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.Common.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.Common.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.Common.StateCommon.Back.ColorAngle = 45F;
            this.PaletaModoClaro.ControlStyles.ControlGroupBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.ControlStyles.ControlGroupBox.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoClaro.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.PaletaModoClaro.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.PaletaModoClaro.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.GridStyles.GridCommon.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.GridStyles.GridCommon.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.PaletaModoClaro.GridStyles.GridCommon.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.GridStyles.GridCommon.StateNormal.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.PaletaModoClaro.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.PaletaModoClaro.InputControlStyles.InputControlStandalone.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaletaModoClaro.InputControlStyles.InputControlStandalone.StateActive.Border.Rounding = 0;
            this.PaletaModoClaro.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.PanelStyles.PanelClient.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.PanelStyles.PanelCommon.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.PanelStyles.PanelCustom1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PaletaModoClaro.PanelStyles.PanelCustom1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            // 
            // FrmRegistrar
            // 
            this.AcceptButton = this.kcmdRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(422, 597);
            this.Controls.Add(this.pnlTermYCond);
            this.Controls.Add(this.kcmdRegistrar);
            this.Controls.Add(this.ktxtContraseña);
            this.Controls.Add(this.ktxtCorreo);
            this.Controls.Add(this.ktxtApellido);
            this.Controls.Add(this.ktxtNombre);
            this.Controls.Add(this.lblTermYCond);
            this.Controls.Add(this.cboxTermYCond);
            this.Controls.Add(this.PboxMyScheduleLogo);
            this.Controls.Add(this.kcmdCerrar);
            this.Controls.Add(this.kcmdCancelar);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistrar";
            this.Palette = this.PaletaModoClaro;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySchedule - Registrar";
            this.Load += new System.EventHandler(this.FrmRegistrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PboxMyScheduleLogo)).EndInit();
            this.pnlTermYCond.ResumeLayout(false);
            this.pnlTermYCond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PboxMyScheduleLogo;
        private System.Windows.Forms.CheckBox cboxTermYCond;
        private System.Windows.Forms.LinkLabel lblTermYCond;
        private System.Windows.Forms.Panel pnlTermYCond;
        private System.Windows.Forms.Label lblTermYCondText;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtApellido;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtCorreo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtContraseña;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kcmdRegistrar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kcmdCerrar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kcmdCancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette PaletaModoOscuro;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette PaletaModoClaro;
    }
}