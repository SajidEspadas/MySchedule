
namespace MySchedule
{
    partial class FrmAgregarDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarDocente));
            this.kgboxAgregarDocente = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.ktxtTelefonoDocente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kcmdCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcmdGuardar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktxtCorreoDocente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtApellidoDocente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtNombreDocente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.PaletaModoOscuro = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.PaletaModoClaro = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kgboxAgregarDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgboxAgregarDocente.Panel)).BeginInit();
            this.kgboxAgregarDocente.Panel.SuspendLayout();
            this.kgboxAgregarDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // kgboxAgregarDocente
            // 
            this.kgboxAgregarDocente.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kgboxAgregarDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kgboxAgregarDocente.Location = new System.Drawing.Point(0, 0);
            this.kgboxAgregarDocente.Name = "kgboxAgregarDocente";
            // 
            // kgboxAgregarDocente.Panel
            // 
            this.kgboxAgregarDocente.Panel.Controls.Add(this.ktxtTelefonoDocente);
            this.kgboxAgregarDocente.Panel.Controls.Add(this.kcmdCancelar);
            this.kgboxAgregarDocente.Panel.Controls.Add(this.kcmdGuardar);
            this.kgboxAgregarDocente.Panel.Controls.Add(this.ktxtCorreoDocente);
            this.kgboxAgregarDocente.Panel.Controls.Add(this.ktxtApellidoDocente);
            this.kgboxAgregarDocente.Panel.Controls.Add(this.ktxtNombreDocente);
            this.kgboxAgregarDocente.Size = new System.Drawing.Size(533, 254);
            this.kgboxAgregarDocente.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kgboxAgregarDocente.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kgboxAgregarDocente.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgboxAgregarDocente.StateNormal.Border.Rounding = 10;
            this.kgboxAgregarDocente.StateNormal.Border.Width = 1;
            this.kgboxAgregarDocente.TabIndex = 2;
            this.kgboxAgregarDocente.Values.Heading = "Datos del docente";
            // 
            // ktxtTelefonoDocente
            // 
            this.ktxtTelefonoDocente.Location = new System.Drawing.Point(8, 113);
            this.ktxtTelefonoDocente.Name = "ktxtTelefonoDocente";
            this.ktxtTelefonoDocente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ktxtTelefonoDocente.Size = new System.Drawing.Size(509, 27);
            this.ktxtTelefonoDocente.TabIndex = 3;
            this.ktxtTelefonoDocente.Text = "Telefono";
            this.ktxtTelefonoDocente.Enter += new System.EventHandler(this.ktxtTelefonoDocente_Enter);
            this.ktxtTelefonoDocente.Leave += new System.EventHandler(this.ktxtTelefonoDocente_Leave);
            // 
            // kcmdCancelar
            // 
            this.kcmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kcmdCancelar.Location = new System.Drawing.Point(406, 158);
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
            this.kcmdCancelar.Size = new System.Drawing.Size(111, 49);
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
            this.kcmdCancelar.TabIndex = 5;
            this.kcmdCancelar.Values.Text = "Cancelar";
            this.kcmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // kcmdGuardar
            // 
            this.kcmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kcmdGuardar.Location = new System.Drawing.Point(288, 158);
            this.kcmdGuardar.Name = "kcmdGuardar";
            this.kcmdGuardar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdGuardar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdGuardar.OverrideDefault.Back.ColorAngle = 45F;
            this.kcmdGuardar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdGuardar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdGuardar.OverrideDefault.Border.ColorAngle = 45F;
            this.kcmdGuardar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdGuardar.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdGuardar.OverrideDefault.Border.Rounding = 20;
            this.kcmdGuardar.OverrideDefault.Border.Width = 1;
            this.kcmdGuardar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kcmdGuardar.Size = new System.Drawing.Size(112, 49);
            this.kcmdGuardar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdGuardar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kcmdGuardar.StateCommon.Back.ColorAngle = 45F;
            this.kcmdGuardar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdGuardar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdGuardar.StateCommon.Border.ColorAngle = 45F;
            this.kcmdGuardar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdGuardar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdGuardar.StateCommon.Border.Rounding = 20;
            this.kcmdGuardar.StateCommon.Border.Width = 1;
            this.kcmdGuardar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdGuardar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmdGuardar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kcmdGuardar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kcmdGuardar.StatePressed.Back.ColorAngle = 135F;
            this.kcmdGuardar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdGuardar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kcmdGuardar.StatePressed.Border.ColorAngle = 135F;
            this.kcmdGuardar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdGuardar.StatePressed.Border.Rounding = 20;
            this.kcmdGuardar.StatePressed.Border.Width = 1;
            this.kcmdGuardar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kcmdGuardar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdGuardar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdGuardar.StateTracking.Back.ColorAngle = 45F;
            this.kcmdGuardar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kcmdGuardar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kcmdGuardar.StateTracking.Border.ColorAngle = 45F;
            this.kcmdGuardar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdGuardar.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmdGuardar.StateTracking.Border.Rounding = 20;
            this.kcmdGuardar.StateTracking.Border.Width = 1;
            this.kcmdGuardar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kcmdGuardar.TabIndex = 4;
            this.kcmdGuardar.Values.Text = "Guardar";
            this.kcmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // ktxtCorreoDocente
            // 
            this.ktxtCorreoDocente.Location = new System.Drawing.Point(8, 80);
            this.ktxtCorreoDocente.Name = "ktxtCorreoDocente";
            this.ktxtCorreoDocente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ktxtCorreoDocente.Size = new System.Drawing.Size(509, 27);
            this.ktxtCorreoDocente.TabIndex = 2;
            this.ktxtCorreoDocente.Text = "Correo";
            this.ktxtCorreoDocente.Enter += new System.EventHandler(this.ktxtCorreoDocente_Enter);
            this.ktxtCorreoDocente.Leave += new System.EventHandler(this.ktxtCorreoDocente_Leave);
            // 
            // ktxtApellidoDocente
            // 
            this.ktxtApellidoDocente.Location = new System.Drawing.Point(8, 47);
            this.ktxtApellidoDocente.Name = "ktxtApellidoDocente";
            this.ktxtApellidoDocente.Size = new System.Drawing.Size(509, 27);
            this.ktxtApellidoDocente.TabIndex = 1;
            this.ktxtApellidoDocente.Text = "Apellido del docente";
            this.ktxtApellidoDocente.Enter += new System.EventHandler(this.ktxtApellidoDocente_Enter);
            this.ktxtApellidoDocente.Leave += new System.EventHandler(this.ktxtApellidoDocente_Leave);
            // 
            // ktxtNombreDocente
            // 
            this.ktxtNombreDocente.Location = new System.Drawing.Point(8, 14);
            this.ktxtNombreDocente.Name = "ktxtNombreDocente";
            this.ktxtNombreDocente.Size = new System.Drawing.Size(509, 27);
            this.ktxtNombreDocente.TabIndex = 0;
            this.ktxtNombreDocente.Text = "Nombre del docente";
            this.ktxtNombreDocente.Enter += new System.EventHandler(this.ktxtNombreDocente_Enter);
            this.ktxtNombreDocente.Leave += new System.EventHandler(this.ktxtNombreDocente_Leave);
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
            this.kryptonPalette1.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.PanelStyles.PanelClient.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.PanelStyles.PanelCommon.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.PanelStyles.PanelCustom1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.PanelStyles.PanelCustom1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
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
            // FrmAgregarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 254);
            this.Controls.Add(this.kgboxAgregarDocente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarDocente";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Text = "Agregar docente";
            this.Load += new System.EventHandler(this.FrmAgregarDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kgboxAgregarDocente.Panel)).EndInit();
            this.kgboxAgregarDocente.Panel.ResumeLayout(false);
            this.kgboxAgregarDocente.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgboxAgregarDocente)).EndInit();
            this.kgboxAgregarDocente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgboxAgregarDocente;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kcmdCancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kcmdGuardar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtCorreoDocente;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtApellidoDocente;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtNombreDocente;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtTelefonoDocente;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette PaletaModoOscuro;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette PaletaModoClaro;
    }
}