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

        // || ============================================================================= || //

        // ===== [ INICIO MÉTODOS ] ===== //

        // Método para desplegar advertencia de error.
        private bool MensajeError(string Espacio, string Descripción, Control Elemento)
        {
            // Establecemos el encabezado del [MessageBox].
            string Título = "Hubo un error en " + Espacio;

            // Mostramos [MessageBox].
            MessageBox.Show(Descripción, Título);

            // Centramos el cursor en el espacio donde ocurrió el error.
            Elemento.Focus();

            // Retornamos valor [bool].
            return false;
        }

        // Método para validar las entradas de los datos.
        private bool ValidarDatos()
        {
            // Generamos una nueva instancia de la clase [Usuario].
            Usuario Usuario = new Usuario();

            // Verificamos los [Textbox].
            if (txtCorreo.Text == "" || txtContraseña.Text == "")
                return MensajeError("Datos ingresados", "Por favor llene todos los datos antes de registrase.", txtCorreo);
            else if (VerificarExistenciaCorreo(txtCorreo))
                return MensajeError("Correo","El correo ingresado no existe", txtCorreo);

            return true;
        }

        // Método para verificar si el [Correo] ya existe.
        private bool VerificarExistenciaCorreo(TextBox txtCorreo)
        {
            // Conectamos la base de datos.
            ConexiónBD.ConectarBD();

            

            // Desconectamos la base de datos.
            ConexiónBD.DesconectarBD();

            return false;
        }

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

        }

        // ===== [ FIN EVENTOS ] ===== //

        // || ============================================================================= || //
    }
}
