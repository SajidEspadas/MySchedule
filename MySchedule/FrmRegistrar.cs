using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Librería necesaria.

namespace MySchedule
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
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

        // Método para reemplazar los acentos no aceptados.
        public static string ReemplazarAcentos(string txtCajaTexto)
        {
            // Establecemos las letras que no son aceptadas.
            Regex Reemplazo_a = new Regex("[á|à|ä|â]", RegexOptions.Compiled);
            Regex Reemplazo_e = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
            Regex Reemplazo_i = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
            Regex Reemplazo_o = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
            Regex Reemplazo_u = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);
            Regex Reemplazo_A = new Regex("[Á]", RegexOptions.Compiled);
            Regex Reemplazo_E = new Regex("[É]", RegexOptions.Compiled);
            Regex Reemplazo_I = new Regex("[Í]", RegexOptions.Compiled);
            Regex Reemplazo_O = new Regex("[Ó]", RegexOptions.Compiled);
            Regex Reemplazo_U = new Regex("[Ú]", RegexOptions.Compiled);

            // Establecemos los reemplazos para dichas letras.
            txtCajaTexto = Reemplazo_a.Replace(txtCajaTexto, "a");
            txtCajaTexto = Reemplazo_e.Replace(txtCajaTexto, "e");
            txtCajaTexto = Reemplazo_i.Replace(txtCajaTexto, "i");
            txtCajaTexto = Reemplazo_o.Replace(txtCajaTexto, "o");
            txtCajaTexto = Reemplazo_u.Replace(txtCajaTexto, "u");
            txtCajaTexto = Reemplazo_A.Replace(txtCajaTexto, "A");
            txtCajaTexto = Reemplazo_E.Replace(txtCajaTexto, "E");
            txtCajaTexto = Reemplazo_I.Replace(txtCajaTexto, "I");
            txtCajaTexto = Reemplazo_O.Replace(txtCajaTexto, "O");
            txtCajaTexto = Reemplazo_U.Replace(txtCajaTexto, "U");

            return txtCajaTexto;
        }

        // Método para validar las entradas de los datos.
        private bool ValidarDatos()
        {
            // Generamos una nueva instancia de la clase [Usuario].
            Usuario Usuario = new Usuario();

            // Verificamos los [Textbox].
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtContraseña.Text == "")
                return MensajeError("Datos ingresados", "Por favor llene todos los datos antes de registrase.", txtNombre);        
            else if (VerificarFormatoCorreo(txtCorreo))
                return MensajeError("Correo", "Por favor ingrese un formato válido", txtCorreo);
            else if (VerificarExistenciaCorreo(txtCorreo))
                return MensajeError("Correo", "El correo que intenta registrar ya existe, por favor ingrese otro correo.", txtCorreo);
            else if (VerificarFormatoContraseña(txtContraseña))
                return MensajeError("Contraseña", "Por favor ingrese una contraseña válida", txtContraseña);

            // Invocamos el método [VerificarLongitud].
            VerificarLongitud(txtNombre, txtApellido, txtCorreo, txtContraseña);
            
            return true;
        }

        // Método para verificar la longitud de los textos ingresados.
        public void VerificarLongitud(TextBox txtNombre, TextBox txtApellido, TextBox txtCorreo, TextBox txtContraseña)
        {

            if (txtNombre.TextLength > 29)
                MensajeError("Nombre","El nombre no puede superar los 30 caracteres!", txtNombre);
            else if (txtApellido.TextLength > 29)
                MensajeError("Apellido","El Apellido no puede superar los 30 caracteres!", txtApellido);
            else if (txtCorreo.TextLength > 49)
                MensajeError("Correo","El Correo no puede superar los 50 caracteres!", txtCorreo);
            else if (txtContraseña.TextLength > 19)
                MensajeError("Contraseña","La contraseña no puede superar los 20 caracteres!", txtContraseña);
        }

        // Método para verificar el formato de [Contraseña].
        private bool VerificarFormatoContraseña(TextBox txtContraseña)
        {
            // Establecemos el [patrón] de la expresión regular que comple con el formato para el [Contraseña].
            string PatronContraseña = "^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$";

            // Verificamos que el correo cumpla con el patrón.
            if (Regex.IsMatch(txtContraseña.Text, PatronContraseña))
                return false;
            else
                return true;
        }

        // Método para verificar si el [Correo] ya existe.
        private bool VerificarExistenciaCorreo(TextBox txtCorreo)
        {
            return false;
        }

        // Método para verificar el formato del [Correo].
        private bool VerificarFormatoCorreo(TextBox txtCorreo)
        {
            // Establecemos el [patrón] de la expresión regular que comple con el formato para el [Correo].
            string PatronCorreo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            // Verificamos que el correo cumpla con el patrón.
            if (Regex.IsMatch(txtCorreo.Text, PatronCorreo))
                return false;
            else
                return true;
        }

        // ===== [ FIN MÉTODOS ] ===== //

        // || ============================================================================= || //

        // ===== [ INICIO EVENTOS ] ===== //

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

            // Desplegamos [MessageBox] para verificar si se desea continuar.
            if(MessageBox.Show("¿Desea cancelar el registro?", "Cancelar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Cerramos la forma [FrmRegistrar].
                Close();

                // Generamos una nueva instancia de la forma [FrmIniciarSesión]
                FrmIniciarSesion FormIniciarSesion = new FrmIniciarSesion();

                // Mostramos la forma
                FormIniciarSesion.Show();
            }
        }

        // Evento para cerrar la aplicación.
        private void pboxCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea cerrar la aplicación","Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        // Evento para volver visible el panel [pnlTermYCond].
        private void lblTermYCond_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Volvemos visible el panel [pnlTermYCond].
            pnlTermYCond.Visible = true;

            // Volvemos visible el botón [cmdCerrar].
            cmdCerrar.Visible = true;
        }

        // Evento para volver invisible el panel [pnlTermYCond].
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            // Volvemos invisible el panel [pnlTermYCond]
            pnlTermYCond.Visible = false;

            // Volvemos invisible el botón [cmdCerrar]
            cmdCerrar.Visible = false;
        }

        // Evento para validar y registrar al usuario.
        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            // Verificamos que los términos y condiciones estén marcadas
            if(cboxTermYCond.Checked == false)
                    MensajeError("Términos y condiciones", "Se deben aceptar los términos y condiciones antes de registrarse!", cboxTermYCond);
            

            ValidarDatos();
        }

        // ===== [ FIN EVENTOS ] ===== //

        // || ============================================================================= || //
    }
}
