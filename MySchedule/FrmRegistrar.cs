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
            {
                Program.MensajeError("Datos ingresados", "Por favor llene todos los datos antes de registrase.");
                return false;
            }

            // Invocamos el método [VerificarLongitud].
            if (VerificarLongitud(txtNombre, txtApellido, txtCorreo, txtContraseña) == false)
                return false;

            if (VerificarExistenciaCorreo(txtCorreo))
            {
                Program.MensajeError("Correo", "El correo que intenta registrar ya existe, por favor ingrese otro correo.");
                return false;
            }

            if (VerificarFormatoCorreo(txtCorreo) == false)
            {
                Program.MensajeError("Correo", "Por favor ingrese un formato válido");
                return false;
            }
            else if (VerificarFormatoContraseña(txtContraseña) == false)
            {
                Program.MensajeError("Contraseña", "Por favor ingrese una contraseña válida");
                return false;
            }

            return true;
        }

        // Método para verificar la longitud de los textos ingresados.
        private bool VerificarLongitud(TextBox txtNombre, TextBox txtApellido, TextBox txtCorreo, TextBox txtContraseña)
        {
            if(txtNombre.TextLength > 29 || txtApellido.TextLength > 29 || txtCorreo.TextLength > 49 || txtContraseña.TextLength > 49)
            {
                Program.MensajeError("Longitud de los datos ingresados", "Verifique que sus datos ingresados cumplan con las especificaciones:" +
                    "\n Nombre no puede ser superior a [30] caracteres." +
                    "\n Apellido no puede ser superior a [30] caracteres." +
                    "\n Correo no puede ser superior a [49] caracteres." +
                    "\n Contraseña no puede ser superior a [49] caracteres.");

                return false;
            }
            return true;
        }

        // Método para verificar el formato de [Contraseña].
        private bool VerificarFormatoContraseña(TextBox txtContraseña)
        {
            // Establecemos el [patrón] de la expresión regular que comple con el formato para el [Contraseña].
            string PatronContraseña = "^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$";

            // Verificamos que el correo cumpla con el patrón.
            if (Regex.IsMatch(txtContraseña.Text, PatronContraseña))
                return true;
            else
            {
                Program.MensajeError("Formato de la contraseña", "Verifique que sus datos ingresados cumplan con las especificaciones:" +
                    "\n Debe de empezar con una letra." +
                    "\n Debe de al menos un número." +
                    "\n Debe de tener una longitud mínima de [8] caracteres" +
                    "\n Debe de tener una longitud máxima de [50] caracteres");
                return false;
            }
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
                return true;
            else
            {
                Program.MensajeError("Formato del correo", "Verifique que sus datos ingresados cumplan con las especificaciones:" +
                    "\n Debe contener el simbolo [@]." +
                    "\n Debe contener al menos una extensión [Ej: \".com\"]" +
                    "\n Debe de tener una longitud máxima de [50] caracteres");
                return false;
            }
        }

        // Método para verificar el que el registro cumpla todos los requisitos.
        private bool VerificarRegistro()
        {
            // Verificamos que los términos y condiciones estén marcadas
            if (cboxTermYCond.Checked == false)
            {
                Program.MensajeError("Términos y condiciones", "Se deben aceptar los términos y condiciones antes de registrarse!");
                return false;
            }

            // Invocamos el método [ValidarDatos].
            if (ValidarDatos() == false)
            {
                Program.MensajeError("Validación de los datos", "Por favor ingrese los datos con su formato correcto");
                return false;
            }

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

                //Invocamos al método[InsertarUsuario].
                if (ConexiónBD.InsertarUsuario(NuevoUsuario) == 0)
                    Program.MensajeError("Inserción de los datos", "Ocurrió un error en los datos insertados");
                else MessageBox.Show("Se han registrado correctamente sus datos, ahora puede iniciar sesión \nPor favor espera unos segundos ya que necesitamos generar sus nuevos horarios...", "Registro exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Obtenemos el [ID] del usuario.
                int ID = ConexiónBD.ObtenerID(txtCorreo, txtContraseña);

                // Invocamos al método [GenerarEspacioDeHorarios].
                if (ID > 0)
                    ConexiónBD.GenerarHorariosUsuarioNuevo(ID);
                else Program.MensajeError("Error generando horarios","Ha ocurrido un error al momento de generar sus horarios!");

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