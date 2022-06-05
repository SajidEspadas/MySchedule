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
    public partial class FrmHorario : Form
    {
        // Variable globales
        int Horario = 1, Dia = 1, Hora = 1, ID;
        string CampoAnterior = "";

        public FrmHorario(int ID)
        {
            InitializeComponent();

            this.ID = ID;

            pnlHorario.Visible = true;
            pnlCalendario.Visible = true;
            pnlUsuario.Visible = true;
            pnlDocente.Visible = true;
            pnlMateria.Visible = true;

            // Invocamos el método [DesplegarHorarios].
            // ConexiónBD.DesplegarHorarios(ID, dgvHorario, Horario, Dia, Hora);

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarDatosUsuario(ID, txtNombre, txtApellido, txtCorreo, txtContraseña);

        }

        // Evento para volver visible el panel [pnlHorario].
        private void pboxHorario_Click(object sender, EventArgs e)
        {
            pnlHorario.Visible = true;
            pnlCalendario.Visible = false;
            pnlUsuario.Visible = false;
            pnlDocente.Visible = false;
            pnlMateria.Visible = false;

            pnlHorario.Dock = DockStyle.Fill;
        }

        // Evento para volver visible el panel [pnlCalendario].
        private void pboxCalendario_Click(object sender, EventArgs e)
        {
            pnlHorario.Visible = false;
            pnlCalendario.Visible = true;
            pnlUsuario.Visible = false;
            pnlDocente.Visible = false;
            pnlMateria.Visible = false;

            pnlCalendario.Dock = DockStyle.Fill;
        }

        // Evento para volver visible el panel [pnlUsuario].
        private void pboxUsuario_Click(object sender, EventArgs e)
        {
            pnlHorario.Visible = false;
            pnlCalendario.Visible = false;
            pnlUsuario.Visible = true;
            pnlDocente.Visible = false;
            pnlMateria.Visible = false;

            pnlUsuario.Dock = DockStyle.Fill;

            // Acomodamos los elementos del panel [pnlUsuario].
            lblNombre.Location.Offset(428, 273);
            lblApellido.Location.Offset(428, 301);
            lblCorreo.Location.Offset(428, 331);
            lblContraseña.Location.Offset(428, 361);

            txtNombre.Location.Offset(570, 270);
            txtApellido.Location.Offset(570, 298);
            txtCorreo.Location.Offset(570, 328);
            txtContraseña.Location.Offset(570, 358);

            cmdEditarNombre.Location.Offset(876, 270);
            cmdEditarApellido.Location.Offset(876, 298);
            cmdEditarCorreo.Location.Offset(876, 326);
            cmdEditarContraseña.Location.Offset(876, 358);
        }

        // Evento para volver visible el panel [pnlDocente].
        private void pboxDocente_Click(object sender, EventArgs e)
        {
            pnlHorario.Visible = false;
            pnlCalendario.Visible = false;
            pnlUsuario.Visible = false;
            pnlDocente.Visible = true;
            pnlMateria.Visible = false;

            pnlDocente.Dock = DockStyle.Fill;
        }

        // Evento para volver visible el panel [pnlMateria]
        private void pboxMateria_Click(object sender, EventArgs e)
        {
            pnlHorario.Visible = false;
            pnlCalendario.Visible = false;
            pnlUsuario.Visible = false;
            pnlDocente.Visible = false;
            pnlMateria.Visible = true;

            pnlMateria.Dock = DockStyle.Fill;
        }

        // Evento para volver visible todos los paneles.
        private void pboxMultitarea_Click(object sender, EventArgs e)
        {
            // Activamos todos los paneles.
            pnlHorario.Visible = true;
            pnlCalendario.Visible = true;
            pnlUsuario.Visible = true;
            pnlDocente.Visible = true;
            pnlMateria.Visible = true;

            // Quitamos la propiedad [DockStyle] de todos los paneles.
            pnlHorario.Dock = DockStyle.None;
            pnlCalendario.Dock = DockStyle.None;
            pnlUsuario.Dock = DockStyle.None;
            pnlDocente.Dock = DockStyle.None;
            pnlMateria.Dock = DockStyle.None;

            // Regresamos a sus posiciones originales los elementos del panel [pnlUsuario].
            lblNombre.Location.Offset(35, 76);
            lblApellido.Location.Offset(35, 104);
            lblCorreo.Location.Offset(35, 134);
            lblContraseña.Location.Offset(35, 164);

            txtNombre.Location.Offset(181, 73);
            txtApellido.Location.Offset(181, 101);
            txtCorreo.Location.Offset(181, 131);
            txtContraseña.Location.Offset(181, 161);

            cmdEditarNombre.Location.Offset(357, 73);
            cmdEditarApellido.Location.Offset(357, 101);
            cmdEditarCorreo.Location.Offset(357, 129);
            cmdEditarContraseña.Location.Offset(357, 161);

        }

        // Evento para editar los datos personales [Nombre].
        private void cmdEditarNombre_Click(object sender, EventArgs e)
        {
            CampoAnterior = txtNombre.Text;

            txtNombre.Enabled = true;
            txtNombre.ReadOnly = false;
            txtNombre.Focus();
        }

        // Evento para editar los datos personales [Apellido].
        private void cmdEditarApellido_Click(object sender, EventArgs e)
        {
            CampoAnterior = txtApellido.Text;

            txtApellido.Enabled = true;
            txtApellido.ReadOnly = false;
            txtApellido.Focus();
        }

        // Evento para editar los datos personales [Correo].
        private void cmdEditarCorreo_Click(object sender, EventArgs e)
        {
            CampoAnterior = txtCorreo.Text;

            txtCorreo.Enabled = true;
            txtCorreo.ReadOnly = false;
            txtCorreo.Focus();
        }

        // Evento para editar los datos personales [Contraseña].
        private void cmdEditarContraseña_Click(object sender, EventArgs e)
        {
            CampoAnterior = txtContraseña.Text;

            txtContraseña.Enabled = true;
            txtContraseña.ReadOnly = false;
            txtContraseña.Focus();
        }

        // Evento para regresar los datos a su estado original o modificarlos.
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se actualizará el campo " + lblNombre.Text + " " + CampoAnterior.ToString() + " a [" + txtNombre.Text + "], ¿Está seguro?", "Actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ConexiónBD.ActualizarDatoUsuario(txtNombre, ID, 1);
            else ConexiónBD.DesplegarDatosUsuario(ID, txtNombre, txtApellido, txtCorreo, txtContraseña);

            txtNombre.Enabled = false;
            txtNombre.ReadOnly = true;
        }

        // Evento para regresar los datos a su estado original o modificarlos.
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se actualizará el campo " + lblApellido.Text + " " + CampoAnterior.ToString() + " a [" + txtApellido.Text + "], ¿Está seguro?", "Actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ConexiónBD.ActualizarDatoUsuario(txtApellido, ID, 2);
            else ConexiónBD.DesplegarDatosUsuario(ID, txtNombre, txtApellido, txtCorreo, txtContraseña);

            txtApellido.Enabled = false;
            txtApellido.ReadOnly = true;
        }

        // Evento para regresar los datos a su estado original o modificarlos.
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se actualizará el campo " + lblCorreo.Text + " " + CampoAnterior.ToString() + " a [" + txtCorreo.Text + "], ¿Está seguro?", "Actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ConexiónBD.ActualizarDatoUsuario(txtCorreo, ID, 3);
            else ConexiónBD.DesplegarDatosUsuario(ID, txtNombre, txtApellido, txtCorreo, txtContraseña);

            txtCorreo.Enabled = false;
            txtCorreo.ReadOnly = true;
        }

        // Evento para regresar los datos a su estado original o modificarlos.
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se actualizará el campo " + lblContraseña.Text + " " + CampoAnterior.ToString() + " a [" + txtContraseña.Text + "], ¿Está seguro?", "Actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ConexiónBD.ActualizarDatoUsuario(txtContraseña, ID, 4);
            else ConexiónBD.DesplegarDatosUsuario(ID, txtNombre, txtApellido, txtCorreo, txtContraseña);

            txtContraseña.Enabled = false;
            txtContraseña.ReadOnly = true;
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

        // Evento para cerrar sesión.
        private void pboxCerrarSesión_Click(object sender, EventArgs e)
        {
            // Cerramos la forma actual.
            this.Close();

            // Generamos una nueva instancia de la forma [FrmIniciarSesion].
            FrmIniciarSesion IniSes = new FrmIniciarSesion();

            IniSes.Show();

        }
    }
}
