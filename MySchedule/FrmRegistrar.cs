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
using ComponentFactory.Krypton.Toolkit;
using MySchedule.Properties;

namespace MySchedule
{
    public partial class FrmRegistrar : KryptonForm
    {
        public FrmRegistrar()
        {
            InitializeComponent();

            kcmdCerrar.Visible = false;
        }

        // || ============================================================================= || //

        // ===== [ INICIO MÉTODOS ] ===== //

        // Método para reemplazar los acentos no aceptados.
        public static string ReemplazarAcentos(string ktxtCajaTexto)
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
            ktxtCajaTexto = Reemplazo_a.Replace(ktxtCajaTexto, "a");
            ktxtCajaTexto = Reemplazo_e.Replace(ktxtCajaTexto, "e");
            ktxtCajaTexto = Reemplazo_i.Replace(ktxtCajaTexto, "i");
            ktxtCajaTexto = Reemplazo_o.Replace(ktxtCajaTexto, "o");
            ktxtCajaTexto = Reemplazo_u.Replace(ktxtCajaTexto, "u");
            ktxtCajaTexto = Reemplazo_A.Replace(ktxtCajaTexto, "A");
            ktxtCajaTexto = Reemplazo_E.Replace(ktxtCajaTexto, "E");
            ktxtCajaTexto = Reemplazo_I.Replace(ktxtCajaTexto, "I");
            ktxtCajaTexto = Reemplazo_O.Replace(ktxtCajaTexto, "O");
            ktxtCajaTexto = Reemplazo_U.Replace(ktxtCajaTexto, "U");

            return ktxtCajaTexto;
        }

        // Método para validar las entradas de los datos.
        private bool ValidarDatos()
        {
            // Verificamos los [Textbox].
            if (ktxtNombre.Text == "" || ktxtApellido.Text == "" || ktxtCorreo.Text == "" || ktxtContraseña.Text == "")
            {
                Program.MensajeError("Datos ingresados", "Por favor llene todos los datos antes de registrase.");
                return false;
            }

            // Invocamos el método [VerificarLongitud].
            if (VerificarLongitud(ktxtNombre, ktxtApellido, ktxtCorreo, ktxtContraseña) == false)
                return false;

            if (VerificarExistenciaCorreo(ktxtCorreo))
            {
                Program.MensajeError("Correo", "El correo que intenta registrar ya existe, por favor ingrese otro correo.");
                return false;
            }

            if (VerificarFormatoCorreo(ktxtCorreo) == false)
            {
                Program.MensajeError("Correo", "Por favor ingrese un formato válido");
                return false;
            }
            else if (VerificarFormatoContraseña(ktxtContraseña) == false)
            {
                Program.MensajeError("Contraseña", "Por favor ingrese una contraseña válida");
                return false;
            }

            return true;
        }

        // Método para verificar la longitud de los textos ingresados.
        private bool VerificarLongitud(KryptonTextBox ktxtNombre, KryptonTextBox ktxtApellido, KryptonTextBox ktxtCorreo, KryptonTextBox ktxtContraseña)
        {
            if(ktxtNombre.TextLength > 29 || ktxtApellido.TextLength > 29 || ktxtCorreo.TextLength > 49 || ktxtContraseña.TextLength > 49)
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
        private bool VerificarFormatoContraseña(KryptonTextBox ktxtContraseña)
        {
            // Establecemos el [patrón] de la expresión regular que comple con el formato para el [Contraseña].
            string PatronContraseña = "^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$";

            // Verificamos que el correo cumpla con el patrón.
            if (Regex.IsMatch(ktxtContraseña.Text, PatronContraseña))
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
        private bool VerificarExistenciaCorreo(KryptonTextBox ktxtCorreo)
        {
            if (ConexiónBD.VerificarCorreoBD(ktxtCorreo) == true)
                return true;
            return false;
        }

        // Método para verificar el formato del [Correo].
        private bool VerificarFormatoCorreo(KryptonTextBox ktxtCorreo)
        {
            // Establecemos el [patrón] de la expresión regular que comple con el formato para el [Correo].
            string PatronCorreo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            // Verificamos que el correo cumpla con el patrón.
            if (Regex.IsMatch(ktxtCorreo.Text, PatronCorreo))
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
            kcmdCerrar.Visible = true;
        }

        // Evento para volver invisible el panel [pnlTermYCond].
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            // Volvemos invisible el panel [pnlTermYCond]
            pnlTermYCond.Visible = false;

            // Volvemos invisible el botón [cmdCerrar]
            kcmdCerrar.Visible = false;
        }

        // Evento para validar y registrar al usuario.
        public void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (VerificarRegistro() == true)
            {
                // Generamos una nueva instancia de la clase [Usuario].
                Usuario NuevoUsuario = new Usuario(ktxtNombre.Text, ktxtApellido.Text, ktxtCorreo.Text, ktxtContraseña.Text);   

                //Invocamos al método[InsertarUsuario].
                if (ConexiónBD.InsertarUsuario(NuevoUsuario) == 0)
                    Program.MensajeError("Inserción de los datos", "Ocurrió un error en los datos insertados");
                else MessageBox.Show("Se han registrado correctamente sus datos, ahora puede iniciar sesión \nPor favor espera unos segundos ya que necesitamos generar sus nuevos horarios...", "Registro exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Obtenemos el [ID] del usuario.
                int ID = ConexiónBD.ObtenerID(ktxtCorreo, ktxtContraseña);

                // Invocamos al método [GenerarEspacioDeHorarios].
                if (ID > 0)
                    ConexiónBD.GenerarHorariosUsuarioNuevo(ID);
                else Program.MensajeError("Error generando horarios","Ha ocurrido un error al momento de generar sus horarios!");

                // Generamos una nueva instancia de la clase [FrmIniciarSesion].
                FrmIniciarSesion frmIniSes = new FrmIniciarSesion(ktxtCorreo.Text);

                // Mostramos la forma.
                frmIniSes.Show();

                // Cerramos la forma actual.
                this.Close();
            }
        }

        private void ktxtNombre_Enter(object sender, EventArgs e)
        {
            if (ktxtNombre.Text == "Nombre")
            {
                ktxtNombre.Text = "";
                ktxtNombre.ForeColor = Color.Black;
            }
        }

        private void ktxtNombre_Leave(object sender, EventArgs e)
        {
            if (ktxtNombre.Text == "")
            {
                ktxtNombre.Text = "Nombre";
                ktxtNombre.ForeColor = Color.Silver;
            }
        }

        private void ktxtApellido_Enter(object sender, EventArgs e)
        {
            if (ktxtApellido.Text == "Apellido")
            {
                ktxtApellido.Text = "";
                ktxtApellido.ForeColor = Color.Black;
            }
        }

        private void ktxtApellido_Leave(object sender, EventArgs e)
        {
            if (ktxtApellido.Text == "")
            {
                ktxtApellido.Text = "Apellido";
                ktxtApellido.ForeColor = Color.Silver;
            }
        }

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
                ktxtContraseña.Text = "";
                ktxtContraseña.ForeColor = Color.Black;
            }
        }

        private void ktxtContraseña_Leave(object sender, EventArgs e)
        {
            if (ktxtContraseña.Text == "")
            {
                ktxtContraseña.Text = "Contraseña";
                ktxtContraseña.ForeColor = Color.Silver;
            }
        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
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

            ktxtNombre.StateCommon.Content.Color1 = Color.White;
            ktxtNombre.Palette = PaletaModoOscuro;

            ktxtApellido.StateCommon.Content.Color1 = Color.White;
            ktxtApellido.Palette = PaletaModoOscuro;

            ktxtCorreo.StateCommon.Content.Color1 = Color.White;
            ktxtCorreo.Palette = PaletaModoOscuro;

            ktxtContraseña.StateCommon.Content.Color1 = Color.White;
            ktxtContraseña.Palette = PaletaModoOscuro;

            kcmdRegistrar.StateNormal.Back.Color1 = Color.DimGray;
            kcmdRegistrar.StateNormal.Back.Color2 = Color.DimGray;
            kcmdRegistrar.Palette = PaletaModoOscuro;

            kcmdCancelar.StateNormal.Back.Color1 = Color.DimGray;
            kcmdCancelar.StateNormal.Back.Color2 = Color.DimGray;
            kcmdCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
            kcmdCancelar.Palette = PaletaModoOscuro;

            kcmdCerrar.StateNormal.Back.Color1 = Color.DimGray;
            kcmdCerrar.StateNormal.Back.Color2 = Color.DimGray;
            kcmdCerrar.StateCommon.Content.ShortText.Color1 = Color.White;
            kcmdCerrar.Palette = PaletaModoOscuro;

            lblTermYCond.LinkColor = Color.White;

            pnlTermYCond.BackColor = Color.DimGray;
            lblTermYCondText.ForeColor = Color.White;
        }

        private void ActivarModoClaro()
        {
            Palette = PaletaModoClaro;

            BackColor = Color.FromArgb(252, 250, 250);

            ktxtNombre.StateCommon.Content.Color1 = Color.DimGray;
            ktxtNombre.Palette = PaletaModoClaro;

            ktxtApellido.StateCommon.Content.Color1 = Color.DimGray;
            ktxtApellido.Palette = PaletaModoClaro;

            ktxtCorreo.StateCommon.Content.Color1 = Color.DimGray;
            ktxtCorreo.Palette = PaletaModoClaro;

            ktxtContraseña.StateCommon.Content.Color1 = Color.DimGray;
            ktxtContraseña.Palette = PaletaModoClaro;

            kcmdRegistrar.StateNormal.Back.Color1 = Color.FromArgb(252, 250, 250);
            kcmdRegistrar.StateNormal.Back.Color2 = Color.FromArgb(252, 250, 250);
            kcmdRegistrar.Palette = PaletaModoClaro;

            kcmdCancelar.StateNormal.Back.Color1 = Color.FromArgb(252, 250, 250);
            kcmdCancelar.StateNormal.Back.Color2 = Color.FromArgb(252, 250, 250);
            kcmdCancelar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kcmdCancelar.Palette = PaletaModoClaro;

            kcmdCerrar.StateNormal.Back.Color1 = Color.FromArgb(252, 250, 250);
            kcmdCerrar.StateNormal.Back.Color2 = Color.FromArgb(252, 250, 250);
            kcmdCerrar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kcmdCerrar.Palette = PaletaModoOscuro;

            lblTermYCond.LinkColor = Color.Black;

            pnlTermYCond.BackColor = Color.FromArgb(252, 250, 250);
            lblTermYCondText.ForeColor = Color.Black;
        }

        // ===== [ FIN EVENTOS ] ===== //

        // || ============================================================================= || //
    }
}