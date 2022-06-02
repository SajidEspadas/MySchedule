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
using System.Data.SqlClient;

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
            // Verificamos los [Textbox].
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtContraseña.Text == "")
                return Program.MensajeError("Datos ingresados", "Por favor llene todos los datos antes de registrase.");
            else if (VerificarFormatoCorreo(txtCorreo))
                return Program.MensajeError("Correo", "Por favor ingrese un formato válido");
            else if (VerificarExistenciaCorreo(txtCorreo))
                return Program.MensajeError("Correo", "El correo que intenta registrar ya existe, por favor ingrese otro correo.");
            else if (VerificarFormatoContraseña(txtContraseña))
                return Program.MensajeError("Contraseña", "Por favor ingrese una contraseña válida");

            // Invocamos el método [VerificarLongitud].
            VerificarLongitud(txtNombre, txtApellido, txtCorreo, txtContraseña);

            return true;
        }

        // Método para verificar la longitud de los textos ingresados.
        private void VerificarLongitud(TextBox txtNombre, TextBox txtApellido, TextBox txtCorreo, TextBox txtContraseña)
        {

            if (txtNombre.TextLength > 29)
                Program.MensajeError("Nombre", "El nombre no puede superar los 30 caracteres!");
            else if (txtApellido.TextLength > 29)
                Program.MensajeError("Apellido", "El Apellido no puede superar los 30 caracteres!");
            else if (txtCorreo.TextLength > 49)
                Program.MensajeError("Correo", "El Correo no puede superar los 50 caracteres!");
            else if (txtContraseña.TextLength > 49)
                Program.MensajeError("Contraseña", "La contraseña no puede superar los 50 caracteres!");
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
            if (ConexiónBD.VerificarCorreoBD(txtCorreo) == true)
                return true;
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

        // Método para verificar el que el registro cumpla todos los requisitos.
        private bool VerificarRegistro()
        {
            // Verificamos que los términos y condiciones estén marcadas
            if (cboxTermYCond.Checked == false)
                return Program.MensajeError("Términos y condiciones", "Se deben aceptar los términos y condiciones antes de registrarse!");

            // Invocamos el método [ValidarDatos].
            if (ValidarDatos() == false)
                return Program.MensajeError("Validación de los datos", "Por favor ingrese los datos con su formato correcto");

            return true;
        }

        // ===== [ FIN MÉTODOS ] ===== //

        // || ============================================================================= || //

        // ===== [ INICIO EVENTOS ] ===== //

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

            // Desplegamos [MessageBox] para verificar si se desea continuar.
            if (MessageBox.Show("¿Desea cancelar el registro?", "Cancelar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        public void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (VerificarRegistro() == true)
            {
                // Generamos una nueva instancia de la clase [Usuario].
                Usuario NuevoUsuario = new Usuario(txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtContraseña.Text);

                // Invocamos el método [ConectarBD] para abrir la conexión con la base de datos.
                ConexiónBD.ConectarBD();

                //Invocamos al método[InsertarUsuario].
                if (ConexiónBD.InsertarUsuario(NuevoUsuario) == 0)
                    Program.MensajeError("Inserción de los datos", "Ocurrió un error en los datos insertados");

                // Invocamos el método [DesconectarBD] para cerrar la conexión con la base de datos.
                ConexiónBD.DesconectarBD();

                MessageBox.Show("Se han registrado correctamente sus datos, ahora puede iniciar sesión", "Registro exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Generamos una nueva instancia de la clase [FrmIniciarSesion].
                FrmIniciarSesion frmIniSes = new FrmIniciarSesion(txtCorreo.Text);

                // Mostramos la forma.
                frmIniSes.Show();

                // Cerramos la forma actual.
                this.Close();
            }
        }

        // ===== [ FIN EVENTOS ] ===== //

        // || ============================================================================= || //
    }
}