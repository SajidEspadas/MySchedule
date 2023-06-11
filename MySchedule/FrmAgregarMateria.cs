using ComponentFactory.Krypton.Toolkit;
using MySchedule.Properties;
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
    public partial class FrmAgregarMateria : KryptonForm
    {
        private int Horario, Dia, Hora, ID;

        private void ktxtNombreMateria_Enter(object sender, EventArgs e)
        {
            if (ktxtNombreMateria.Text == "Nombre de la materia")
            {
                ktxtNombreMateria.Text = "";
                ktxtNombreMateria.ForeColor = Color.Black;
            }
        }

        private void ktxtNombreMateria_Leave(object sender, EventArgs e)
        {
            if (ktxtNombreMateria.Text == "")
            {
                ktxtNombreMateria.Text = "Nombre de la materia";
                ktxtNombreMateria.ForeColor = Color.Silver;
            }
        }

        private void ktxtComentarioMateria_Enter(object sender, EventArgs e)
        {
            if (ktxtComentarioMateria.Text == "Comentario (Opcional)")
            {
                ktxtComentarioMateria.Text = "";
                ktxtComentarioMateria.ForeColor = Color.Black;
            }
        }

        private void ktxtComentarioMateria_Leave(object sender, EventArgs e)
        {
            if (ktxtComentarioMateria.Text == "")
            {
                ktxtComentarioMateria.Text = "Comentario (Opcional)";
                ktxtComentarioMateria.ForeColor = Color.Silver;
            }
        }

        private void ktxtNombreAulaMateria_Enter(object sender, EventArgs e)
        {
            if (ktxtNombreAulaMateria.Text == "Aula")
            {
                ktxtNombreAulaMateria.Text = "";
                ktxtNombreAulaMateria.ForeColor = Color.Black;
            }
        }

        private void ktxtNombreAulaMateria_Leave(object sender, EventArgs e)
        {
            if (ktxtNombreAulaMateria.Text == "")
            {
                ktxtNombreAulaMateria.Text = "Aula";
                ktxtNombreAulaMateria.ForeColor = Color.Silver;
            }
        }

        private void FrmAgregarMateria_Load(object sender, EventArgs e)
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

            kgboxAgregarMateria.Palette = PaletaModoOscuro;
            kgboxAgregarMateria.StateNormal.Back.Color1 = Color.DimGray;
            kgboxAgregarMateria.StateNormal.Back.Color2 = Color.DimGray;

            ktxtNombreMateria.Palette = PaletaModoOscuro;
            ktxtNombreMateria.StateCommon.Content.Color1 = Color.White;

            ktxtNombreAulaMateria.Palette = PaletaModoOscuro;
            ktxtNombreAulaMateria.StateCommon.Content.Color1 = Color.White;

            ktxtComentarioMateria.Palette = PaletaModoOscuro;
            ktxtComentarioMateria.StateCommon.Content.Color1 = Color.White;

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

            kgboxAgregarMateria.Palette = PaletaModoOscuro;
            kgboxAgregarMateria.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kgboxAgregarMateria.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);

            ktxtNombreMateria.Palette = PaletaModoClaro;
            ktxtNombreMateria.StateCommon.Content.Color1 = Color.DimGray;

            ktxtNombreAulaMateria.Palette = PaletaModoClaro;
            ktxtNombreAulaMateria.StateCommon.Content.Color1 = Color.DimGray;

            ktxtComentarioMateria.Palette = PaletaModoClaro;
            ktxtComentarioMateria.StateCommon.Content.Color1 = Color.DimGray;

            kcmdGuardar.Palette = PaletaModoClaro;
            kcmdGuardar.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdGuardar.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdGuardar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            kcmdCancelar.Palette = PaletaModoClaro;
            kcmdCancelar.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdCancelar.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdCancelar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
        }

        public FrmAgregarMateria(int horario, int dia, int hora, int iD)
        {
            InitializeComponent();

            Horario = horario;
            Dia = dia;
            Hora = hora;
            ID = iD;
        }

        // Evento para guardar la [Materia].
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            // Validamos los campos
            if (ktxtNombreMateria.Text == "" || ktxtNombreAulaMateria.Text == "" || ktxtNombreMateria.Text == "Nombre de la materia" || ktxtNombreAulaMateria.Text == "Aula")
                MessageBox.Show("Por favor ingrese al menos los campos obligatorios \nNombre de la materia* \nAula*", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (ktxtNombreMateria.Text.Length > 49 || ktxtComentarioMateria.Text.Length > 199 || ktxtNombreAulaMateria.Text.Length > 49)
            {
                MessageBox.Show("Los campos ingresados no pueden superar las siguentes cantidades de caracteres! " +
                    "\nNombre de la materia: [50] caracteres." +
                    "\nComentario: [200] caracteres." +
                    "\nAula: [50] caracteres.",
                    "Longitud de los datos");
            }
            else
            {
                if (ktxtComentarioMateria.Text == "Comentario (Opcional)")
                {
                    ktxtComentarioMateria.Clear();
                }

                // Invocamos el método para guardar los datos de la materia.
                ConexiónBD.ActualizarMateria(ktxtNombreMateria, ktxtComentarioMateria, ktxtNombreAulaMateria, Horario, Dia, Hora, ID);

                // Cerramos la forma [FrmAgregarMateria].
                this.Close();
            }
        }

        // Evento para cerrar la forma [FrmAgregarMateria].
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
