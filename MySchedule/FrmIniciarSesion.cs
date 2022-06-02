using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchedule
{
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        public FrmIniciarSesion(string Correo)
        {
            InitializeComponent();
            txtCorreo.Text = Correo;
        }

        // || ============================================================================= || //

        // ===== [ INICIO MÉTODOS ] ===== //

        // ===== [ FIN MÉTODOS ] ===== //

        // || ============================================================================= || //

        // ===== [ INICIO EVENTOS ] ===== //

        // Evento para invocar forma [Registro]
        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            // Ocultamos la forma actual.
            this.Hide();

            // Generamos una nueva instancia de la forma [FrmRegistrar]
            FrmRegistrar FormRegistrar = new FrmRegistrar();

            // Mostramos la forma [FrmRegistrar]
            FormRegistrar.Show();
        }

        // Evento para cerrar la aplicación.
        private void pboxCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar la aplicación", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Cerramos la aplicación.
                Application.Exit();
            }
        }

        // Evento para minimizar la aplicación.
        private void pboxMinimizar_Click(object sender, EventArgs e)
        {
            // Minimizamos la ventana.
            WindowState = FormWindowState.Minimized;
        }

        // Evento para iniciar sesión.
        private void cmdIniciarSesion_Click(object sender, EventArgs e)
        {
            // Verificamos que el [Correo] y [Contraseña] existen.
            if (ConexiónBD.ValidarInicioDeSesion(txtCorreo, txtContraseña) == true)
            {
                // Invocamos la función [InicioDeSesion] y retornamos el valor del [ID].
                string ID = ConexiónBD.InicioDeSesion(txtCorreo, txtContraseña);

                // Ocultamos la forma anterior [IniciarSesión].
                Hide();

                // Generamos una nueva instancia de la clase [FrmHorario].
                FrmHorario FrmHorario = new FrmHorario(ID);

                // Mostramos la nueva forma [FrmHorario].
                FrmHorario.Show();
            }
            else
            {
                Program.MensajeError("Inicio de sesión", "El correo y/o contraseña no es válido");

                // Limpiamos los [TextBox].
                txtCorreo.Text = "";
                txtContraseña.Text = "";

                // Centramos el [Cursor].
                txtCorreo.Focus();
            }
        }

        // ===== [ FIN EVENTOS ] ===== //

        // || ============================================================================= || //
    }
}