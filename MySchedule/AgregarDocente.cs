using ComponentFactory.Krypton.Toolkit;
using MySchedule.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // Librería necesaria para utilizar expresiones regulares.
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchedule
{
    public partial class FrmAgregarDocente : KryptonForm
    {
        // Variable global
        readonly int ID, Tipo = 0, IDDoc;

        public FrmAgregarDocente(int iD, int tipo)
        {
            InitializeComponent();

            ID = iD;
            Tipo = tipo;

        }

        public FrmAgregarDocente(int iD, int tipo, int IdDoc)
        {
            InitializeComponent();

            ID = iD;
            Tipo = tipo;
            IDDoc = IdDoc;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (ktxtCorreoDocente.Text == "Correo")
                ktxtCorreoDocente.Clear();

            if (ktxtTelefonoDocente.Text == "Telefono")
                ktxtTelefonoDocente.Clear();

            if (ValidarDatos(ktxtNombreDocente, ktxtApellidoDocente, ktxtCorreoDocente, ktxtTelefonoDocente) == true)
            {
                // Si [Tipo = 0] quiere decir que se hará una inserción nueva de docente, si [Tipo = 1] significa que se editará un docente existente.
                if (Tipo == 0)
                    ConexiónBD.InsertarDocente(ID, ktxtNombreDocente, ktxtApellidoDocente, ktxtCorreoDocente, ktxtTelefonoDocente);
                else if (Tipo == 1)
                    ConexiónBD.ActualizarDocente(IDDoc, ktxtNombreDocente, ktxtApellidoDocente, ktxtCorreoDocente, ktxtTelefonoDocente);
                this.Close();
            }
            else
            {
                ktxtCorreoDocente.Text = "Correo";
                ktxtTelefonoDocente.Text = "Telefono";
            }
        }

        private bool ValidarDatos(KryptonTextBox txtNombreDocente, KryptonTextBox txtApellidoDocente, KryptonTextBox txtCorreoDocente, KryptonTextBox txtTelefonoDocente)
        {
            // Validamos los campos.
            if (txtNombreDocente.Text == "" || txtApellidoDocente.Text == "" || txtNombreDocente.Text == "Nombre del docente" || txtApellidoDocente.Text == "Apellido del docente")
            {
                MessageBox.Show("Por favor ingrese los datos obligatorios \nNombre del docente* \nApellido del docente*", "Campos vacíos");
                return false;
            }
            else if (txtNombreDocente.Text.Length > 29 || txtApellidoDocente.Text.Length > 29 || txtCorreoDocente.Text.Length > 49 || txtTelefonoDocente.Text.Length > 10)
            {
                MessageBox.Show("Los campos ingresados no pueden superar las siguentes cantidades de caracteres! " +
                    "\nNombre del docente: [30] caracteres." +
                    "\nApellido del docente: [30] caracteres." +
                    "\nCorreo: [50] caracteres." +
                    "\nTeléfono: [10] caracteres.",
                    "Longitud de los campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtCorreoDocente.Text != "")
            {
                if(VerificarFormatoCorreo(ktxtCorreoDocente) == false)
                    return false;
            }
            else if (txtTelefonoDocente.Text != "")
            {
                if (VerificarFormatoTelefono(ktxtTelefonoDocente) == false)
                    return false;
            }

            return true;
        }

        // Método para verificar el formato del telefono.
        private bool VerificarFormatoTelefono(KryptonTextBox txtTelefonoDocente)
        {
            string PatronTelefono = "\\d{0,10}";

            if(Regex.IsMatch(txtTelefonoDocente.Text, PatronTelefono) == false)
            {
                Program.MensajeError("Formato del telefono","Verifique el telefono cumpla con las siguientes características:" +
                    "\nDebe de tener [10] caracteres." +
                    "\nSolo puede tener números.");
                return false;
            }
            return true;
        }

        private void ktxtNombreDocente_Enter(object sender, EventArgs e)
        {
            if (ktxtNombreDocente.Text == "Nombre del docente")
            {
                ktxtNombreDocente.Text = "";
                ktxtNombreDocente.ForeColor = Color.Black;
            }
        }

        private void ktxtNombreDocente_Leave(object sender, EventArgs e)
        {
            if (ktxtNombreDocente.Text == "")
            {
                ktxtNombreDocente.Text = "Nombre del docente";
                ktxtNombreDocente.ForeColor = Color.Silver;
            }
        }

        private void ktxtApellidoDocente_Enter(object sender, EventArgs e)
        {
            if (ktxtApellidoDocente.Text == "Apellido del docente")
            {
                ktxtApellidoDocente.Text = "";
                ktxtApellidoDocente.ForeColor = Color.Black;
            }
        }

        private void ktxtApellidoDocente_Leave(object sender, EventArgs e)
        {
            if (ktxtApellidoDocente.Text == "")
            {
                ktxtApellidoDocente.Text = "Apellido del docente";
                ktxtApellidoDocente.ForeColor = Color.Silver;
            }
        }

        private void ktxtCorreoDocente_Enter(object sender, EventArgs e)
        {
            if (ktxtCorreoDocente.Text == "Correo")
            {
                ktxtCorreoDocente.Text = "";
                ktxtCorreoDocente.ForeColor = Color.Black;
            }
        }

        private void ktxtCorreoDocente_Leave(object sender, EventArgs e)
        {
            if (ktxtCorreoDocente.Text == "")
            {
                ktxtCorreoDocente.Text = "Correo";
                ktxtCorreoDocente.ForeColor = Color.Silver;
            }
        }

        private void ktxtTelefonoDocente_Enter(object sender, EventArgs e)
        {
            if (ktxtTelefonoDocente.Text == "Telefono")
            {
                ktxtTelefonoDocente.Text = "";
                ktxtTelefonoDocente.ForeColor = Color.Black;
            }
        }

        private void ktxtTelefonoDocente_Leave(object sender, EventArgs e)
        {
            if (ktxtTelefonoDocente.Text == "")
            {
                ktxtTelefonoDocente.Text = "Telefono";
                ktxtTelefonoDocente.ForeColor = Color.Silver;
            }
        }

        private void FrmAgregarDocente_Load(object sender, EventArgs e)
        {
            if ((bool)Settings.Default["ModoOscuro"] == false)
                ActivarModoClaro();
            else
                ActivarModoOscuro();
        }

        private void ActivarModoOscuro()
        {
            Palette = PaletaModoOscuro;

            this.BackColor = Color.DimGray;

            kgboxAgregarDocente.Palette = PaletaModoOscuro;
            kgboxAgregarDocente.StateNormal.Back.Color1 = Color.DimGray;
            kgboxAgregarDocente.StateNormal.Back.Color2 = Color.DimGray;

            ktxtNombreDocente.Palette = PaletaModoOscuro;
            ktxtNombreDocente.StateCommon.Content.Color1 = Color.White;

            ktxtApellidoDocente.Palette = PaletaModoOscuro;
            ktxtApellidoDocente.StateCommon.Content.Color1 = Color.White;

            ktxtCorreoDocente.Palette = PaletaModoOscuro;
            ktxtCorreoDocente.StateCommon.Content.Color1 = Color.White;

            ktxtTelefonoDocente.Palette = PaletaModoOscuro;
            ktxtTelefonoDocente.StateCommon.Content.Color1 = Color.White;

            kcmdGuardar.Palette = PaletaModoOscuro;
            kcmdGuardar.StateNormal.Back.Color1 = Color.DimGray;
            kcmdGuardar.StateNormal.Back.Color2 = Color.DimGray;
            kcmdGuardar.StateCommon.Content.ShortText.Color1 = Color.White;

            kcmdCancelar.Palette = PaletaModoOscuro;
            kcmdCancelar.StateNormal.Back.Color1 = Color.DimGray;
            kcmdCancelar.StateNormal.Back.Color2 = Color.DimGray;
            kcmdCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
        }

        private void ActivarModoClaro()
        {
            Palette = PaletaModoClaro;

            this.BackColor = Color.FromArgb(250, 252, 252);

            kgboxAgregarDocente.Palette = PaletaModoOscuro;
            kgboxAgregarDocente.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kgboxAgregarDocente.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);

            ktxtNombreDocente.Palette = PaletaModoClaro;
            ktxtNombreDocente.StateCommon.Content.Color1 = Color.DimGray;

            ktxtApellidoDocente.Palette = PaletaModoClaro;
            ktxtApellidoDocente.StateCommon.Content.Color1 = Color.DimGray;

            ktxtCorreoDocente.Palette = PaletaModoClaro;
            ktxtCorreoDocente.StateCommon.Content.Color1 = Color.DimGray;

            ktxtTelefonoDocente.Palette = PaletaModoClaro;
            ktxtTelefonoDocente.StateCommon.Content.Color1 = Color.DimGray;

            kcmdGuardar.Palette = PaletaModoClaro;
            kcmdGuardar.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdGuardar.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdGuardar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            kcmdCancelar.Palette = PaletaModoClaro;
            kcmdCancelar.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdCancelar.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdCancelar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
        }

        // Método para verificar el formato del correo.
        private bool VerificarFormatoCorreo(KryptonTextBox txtCorreoDocente)
        {
            string PatronCorreo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            // Verificamos que el correo cumpla con el patrón.
            if (Regex.IsMatch(txtCorreoDocente.Text, PatronCorreo) == false)
            {
                Program.MensajeError("Formato del correo", "Verifique que sus datos ingresados cumplan con las especificaciones:" +
                    "\n Debe contener el simbolo [@]." +
                    "\n Debe contener al menos una extensión [Ej: \".com\"]" +
                    "\n Debe de tener una longitud máxima de [50] caracteres");
                return false;
            }
            return true;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
