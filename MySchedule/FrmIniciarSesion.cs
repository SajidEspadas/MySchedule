using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySchedule.Properties;

namespace MySchedule
{
    public partial class FrmIniciarSesion : KryptonForm
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        public FrmIniciarSesion(string Correo)
        {
            InitializeComponent();
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {
            if ((bool)Settings.Default["ModoOscuro"] == false)
                ActivarModoClaro();
            else
                ActivarModoOscuro();
        }

        private void ActivarModoOscuro()
        {
            Palette = PaletaModoOscuro;

            BackColor = Color.DimGray;

            ktxtCorreo.StateCommon.Content.Color1 = Color.White;
            ktxtCorreo.Palette = PaletaModoOscuro;

            ktxtContraseña.StateCommon.Content.Color1 = Color.White;
            ktxtContraseña.Palette = PaletaModoOscuro;

            kcmdIniciarSesion.StateNormal.Back.Color1 = Color.DimGray;
            kcmdIniciarSesion.StateNormal.Back.Color2 = Color.DimGray;
            kcmdIniciarSesion.Palette = PaletaModoOscuro;

            kcmdRegistrar.StateNormal.Back.Color1 = Color.DimGray;
            kcmdRegistrar.StateNormal.Back.Color2 = Color.DimGray;
            kcmdRegistrar.StateCommon.Content.ShortText.Color1 = Color.White;
            kcmdRegistrar.Palette = PaletaModoOscuro;
        }

        private void ActivarModoClaro()
        {
            Palette = PaletaModoClaro;

            BackColor = Color.FromArgb(252, 250, 250);

            ktxtCorreo.StateCommon.Content.Color1 = Color.DimGray;
            ktxtCorreo.Palette = PaletaModoClaro;

            ktxtContraseña.StateCommon.Content.Color1 = Color.DimGray;
            ktxtContraseña.Palette = PaletaModoClaro;

            kcmdIniciarSesion.StateNormal.Back.Color1 = Color.FromArgb(252, 250, 250);
            kcmdIniciarSesion.StateNormal.Back.Color2 = Color.FromArgb(252, 250, 250);
            kcmdIniciarSesion.Palette = PaletaModoClaro;

            kcmdRegistrar.StateNormal.Back.Color1 = Color.FromArgb(252, 250, 250);
            kcmdRegistrar.StateNormal.Back.Color2 = Color.FromArgb(252, 250, 250);
            kcmdRegistrar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kcmdRegistrar.Palette = PaletaModoClaro;
            
        }

        // || ============================================================================= || //

        // ===== [ INICIO MÉTODOS ] ===== //

        // ===== [ FIN MÉTODOS ] ===== //

        // || ============================================================================= || //

        // ===== [ INICIO EVENTOS ] ===== //
        private void ktxtCorreo_Enter(object sender, EventArgs e)
        {
            if (ktxtCorreo.Text == "Correo")
            {
                ktxtCorreo.Text = "";
                ktxtCorreo.ForeColor = Color.Black;
            }
        }

        private void ktxtCorreo_Leave(object sender, EventArgs e)
        {
            if (ktxtCorreo.Text == "")
            {
                ktxtCorreo.Text = "Correo";
                ktxtCorreo.ForeColor = Color.Silver;
            }
        }

        private void ktxtContraseña_Enter(object sender, EventArgs e)
        {
            if (ktxtContraseña.Text == "Contraseña")
            {   
                ktxtContraseña.UseSystemPasswordChar = true;
                ktxtContraseña.Text = "";
                ktxtContraseña.ForeColor = Color.Black;
            }
        }

        private void ktxtContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ktxtContraseña.Text))
            {
                ktxtContraseña.Text = "Contraseña";
                ktxtContraseña.ForeColor = Color.Silver;
                ktxtContraseña.UseSystemPasswordChar = false;
            }
        }

        // Evento para invocar forma [Registro]
        private void kcmdRegistrar_Click(object sender, EventArgs e)
        {
            // Ocultamos la forma actual.
            this.Hide();

            // Generamos una nueva instancia de la forma [FrmRegistrar]
            FrmRegistrar FormRegistrar = new FrmRegistrar();

            // Mostramos la forma [FrmRegistrar]
            FormRegistrar.Show();
        }

        private void kcmdIniciarSesion_Click(object sender, EventArgs e)
        {
            // Verificamos que el [Correo] y [Contraseña] existen.
            if (ConexiónBD.ValidarInicioDeSesion(ktxtCorreo, ktxtContraseña) == true)
            {
                // Invocamos la función [InicioDeSesion] y retornamos el valor del [ID].
                int ID = ConexiónBD.InicioDeSesion(ktxtCorreo, ktxtContraseña);

                // Ocultamos la forma anterior [IniciarSesión].
                this.Hide();

                // Generamos una nueva instancia de la clase [FrmHorario].
                FrmHorario FrmHorario = new FrmHorario(ID);

                // Mostramos la nueva forma [FrmHorario].
                FrmHorario.Show();
            }
            else
            {
                Program.MensajeError("Inicio de sesión", "El correo y/o contraseña no es válido");

                // Limpiamos los [TextBox].
                ktxtCorreo.Text = "";
                ktxtContraseña.Text = "";

                // Centramos el [Cursor].
                ktxtCorreo.Focus();
            }
        }

        // ===== [ FIN EVENTOS ] ===== //

        // || ============================================================================= || //
    }
}