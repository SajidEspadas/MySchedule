using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySchedule.Properties;
using System.Configuration;

namespace MySchedule
{
    public partial class FrmHorario : KryptonForm
    {
        // Variables globales.
        int Horario = 1, Dia = 1, Hora = 1, ID, IDDocTemp;
        string CampoAnterior = "", NombreTemp, ApellidoTemp, CorreoTemp, TelefonoTemp;

        public FrmHorario(int ID)
        {
            InitializeComponent();

            this.ID = ID;

            ktsmHorario1.Enabled = false;
            ktsmLunes.Enabled = false;

            kcmdMenuCerrar.Visible = false;
            kcmdHorario.Visible = false;
            kcmdUsuario.Visible = false;
            kcmdDocente.Visible = false;
            kcmdMateria.Visible = false;
            kcmdMultitarea.Visible = false;
            kchkbModoClaroOscuro.Visible = false;
            kcmdCerrarSesion.Visible = false;

            // ActivarModoClaro();

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);

            // Invocamos el método [DesplegarDocente].
            ConexiónBD.DesplegarDocente(kdgvDocente, ID);

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarDatosUsuario(ID, ktxtNombre, ktxtApellido, ktxtCorreo, ktxtContraseña);

            // Invocamos el método [DesplegarMateria].
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);

        }

        private void FrmHorario_Load(object sender, EventArgs e)
        {
            kchkbModoClaroOscuro.Checked = (bool)Settings.Default["ModoOscuro"];
        }

        // Evento para volver visible el panel [pnlHorario].
        private void pboxHorario_Click(object sender, EventArgs e)
        {
            kcmdHorario.Enabled = false;
            kcmdUsuario.Enabled = true;
            kcmdDocente.Enabled = true;
            kcmdMateria.Enabled = true;
            kcmdMultitarea.Enabled = true;

            kpnlHorario.Visible = true;
            kpnlUsuario.Visible = false;
            kpnlDocente.Visible = false;
            kpnlMateria.Visible = false;

            kpnlHorario.Dock = DockStyle.Fill;
            //kgboxSemana.Dock = DockStyle.Fill;
        }

        // Evento para volver visible el panel [pnlCalendario].
        //private void pboxCalendario_Click(object sender, EventArgs e)
        //{
        //    kpnlHorario.Visible = false;
        //    kpnlUsuario.Visible = false;
        //    kpnlDocente.Visible = false;
        //    kpnlMateria.Visible = false;
        //}

        // Evento para volver visible el panel [kpnlUsuario].
        private void pboxUsuario_Click(object sender, EventArgs e)
        {
            kcmdHorario.Enabled = true;
            kcmdUsuario.Enabled = false;
            kcmdDocente.Enabled = true;
            kcmdMateria.Enabled = true;
            kcmdMultitarea.Enabled = true;

            kpnlHorario.Visible = false;
            kpnlUsuario.Visible = true;
            kpnlDocente.Visible = false;
            kpnlMateria.Visible = false;

            kpnlUsuario.Dock = DockStyle.Fill;

            // Acomodamos los elementos del panel [kpnlUsuario].
            //lblNombre.Location.Offset(428, 273);
            //lblApellido.Location.Offset(428, 301);
            //lblCorreo.Location.Offset(428, 331);
            //lblContraseña.Location.Offset(428, 361);

            //txtNombre.Location.Offset(570, 270);
            //txtApellido.Location.Offset(570, 298);
            //txtCorreo.Location.Offset(570, 328);
            //txtContraseña.Location.Offset(570, 358);

            //cmdEditarNombre.Location.Offset(876, 270);
            //cmdEditarApellido.Location.Offset(876, 298);
            //cmdEditarCorreo.Location.Offset(876, 326);
            //cmdEditarContraseña.Location.Offset(876, 358);
        }

        // Evento para volver visible el panel [kpnlDocente].
        private void pboxDocente_Click(object sender, EventArgs e)
        {
            kcmdHorario.Enabled = true;
            kcmdUsuario.Enabled = true;
            kcmdDocente.Enabled = false;
            kcmdMateria.Enabled = true;
            kcmdMultitarea.Enabled = true;

            kpnlHorario.Visible = false;
            kpnlUsuario.Visible = false;
            kpnlDocente.Visible = true;
            kpnlMateria.Visible = false;

            kpnlDocente.Dock = DockStyle.Fill;
        }

        // Evento para volver visible el panel [pnlMateria]
        private void pboxMateria_Click(object sender, EventArgs e)
        {
            kcmdHorario.Enabled = true;
            kcmdUsuario.Enabled = true;
            kcmdDocente.Enabled = true;
            kcmdMateria.Enabled = false;
            kcmdMultitarea.Enabled = true;

            kpnlHorario.Visible = false;            
            kpnlUsuario.Visible = false;
            kpnlDocente.Visible = false;
            kpnlMateria.Visible = true;

            kpnlMateria.Dock = DockStyle.Fill;
        }

        // Evento para volver visible todos los paneles.
        private void pboxMultitarea_Click(object sender, EventArgs e)
        {
            kcmdHorario.Enabled = true;
            kcmdUsuario.Enabled = true;
            kcmdDocente.Enabled = true;
            kcmdMateria.Enabled = true;
            kcmdMultitarea.Enabled = false;

            // Activamos todos los paneles.
            kpnlHorario.Visible = true;
            kpnlUsuario.Visible = true;
            kpnlDocente.Visible = true;
            kpnlMateria.Visible = true;

            // Quitamos la propiedad [DockStyle] de todos los paneles.
            kpnlHorario.Dock = DockStyle.None;
            kpnlUsuario.Dock = DockStyle.None;
            kpnlDocente.Dock = DockStyle.None;
            kpnlMateria.Dock = DockStyle.None;

            // Regresamos a sus posiciones originales los elementos del panel [kpnlUsuario].
            //klblNombre.Location.Offset(35, 76);
            //klblApellido.Location.Offset(35, 104);
            //klblCorreo.Location.Offset(35, 134);
            //klblContraseña.Location.Offset(35, 164);

            //ktxtNombre.Location.Offset(181, 73);
            //ktxtApellido.Location.Offset(181, 101);
            //ktxtCorreo.Location.Offset(181, 131);
            //ktxtContraseña.Location.Offset(181, 161);

            //kcmdEditarNombre.Location.Offset(357, 73);
            //kcmdEditarApellido.Location.Offset(357, 101);
            //kcmdEditarCorreo.Location.Offset(357, 129);
            //kcmdEditarContraseña.Location.Offset(357, 161);

        }

        // Evento para modificar [Materia] del [dgvHorario].
        private void dgvHorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Obtenemos la hora.
            Hora = Convert.ToInt32(kdgvHorario.CurrentRow.Cells[0].Value.ToString());

            if (ConexiónBD.VerificarMat_Activa(ID, Horario, Dia, Hora) == true)
            {
                // Nueva instancia de la forma [FrmEditarEliminarMateria].
                FrmMEditarEliminarMateria frmEdiEliMat = new FrmMEditarEliminarMateria();

                frmEdiEliMat.ShowDialog();

                // Si DialosResult.Yes, se edita la materia.
                if (frmEdiEliMat.DialogResult == DialogResult.Yes)
                {
                    FrmAgregarMateria frmAgrMat1 = new FrmAgregarMateria(Horario, Dia, Hora, ID);

                    frmAgrMat1.ShowDialog();
                }
                else  if(frmEdiEliMat.DialogResult == DialogResult.No)
                {
                    if (MessageBox.Show("¿Desea eliminar la materia?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        ConexiónBD.EliminarMateria(ID, Horario, Dia, Hora);
                }
            }
            else
            {
                FrmAgregarMateria frmAgrMat2 = new FrmAgregarMateria(Horario, Dia, Hora, ID);

                frmAgrMat2.ShowDialog();
            }


            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);

            // Invocamos el método [DesplegarMateria].
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);
        }

        // Evento para desplegar los docentes.
        private void cmdAgregarDocente_Click(object sender, EventArgs e)
        {
            // Generamos una nueva instancia de la forma [FrmAgregarDocente].
            FrmAgregarDocente frmAgrDoc = new FrmAgregarDocente(ID, 0);

            frmAgrDoc.ShowDialog();

            ConexiónBD.DesplegarDocente(kdgvDocente, ID);
        }

        // Evento para eliminar docente.
        private void kdgvDocente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtenemos los datos del docente seleccionado.
            NombreTemp = kdgvDocente.CurrentRow.Cells[0].Value.ToString();
            ApellidoTemp = kdgvDocente.CurrentRow.Cells[1].Value.ToString();
            CorreoTemp = kdgvDocente.CurrentRow.Cells[2].Value.ToString();
            TelefonoTemp = kdgvDocente.CurrentRow.Cells[3].Value.ToString();

            IDDocTemp = ConexiónBD.ObtenerIDDocente(ID, NombreTemp, ApellidoTemp, CorreoTemp, TelefonoTemp);

            // Generamos una nueva instancia de la forma [FrmEditarEliminarDocente].
            FrmEditarEliminarDocente frmEdiEliDoc = new FrmEditarEliminarDocente();

            frmEdiEliDoc.ShowDialog();

            if (frmEdiEliDoc.DialogResult == DialogResult.Yes)
            {
                frmEdiEliDoc.Close();

                // Generamos una nueva instancia de la forma [FrmAgregarDocente].
                FrmAgregarDocente frmAgrDoc = new FrmAgregarDocente(ID, 1, IDDocTemp);

                frmAgrDoc.ShowDialog();                
            }
            if (frmEdiEliDoc.DialogResult == DialogResult.No)
            {
                if (MessageBox.Show("¿Desea eliminar al docente? \n" + NombreTemp.ToString() + "\n" + ApellidoTemp.ToString() + "\n" + CorreoTemp + "\n" + TelefonoTemp, "Eliminar docente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    ConexiónBD.EliminarDocente(IDDocTemp, ID);

            }

            // Invocamos el método [ConexiónBD.DesplegarDocente]            
            ConexiónBD.DesplegarDocente(kdgvDocente, ID);
        }

        // Evento para editar los datos personales [Nombre].
        private void cmdEditarNombre_Click(object sender, EventArgs e)
        {
            CampoAnterior = ktxtNombre.Text;

            ktxtNombre.Enabled = true;
            ktxtNombre.ReadOnly = false;
            ktxtNombre.Focus();
        }

        // Evento para editar los datos personales [Apellido].
        private void cmdEditarApellido_Click(object sender, EventArgs e)
        {
            CampoAnterior = ktxtApellido.Text;

            ktxtApellido.Enabled = true;
            ktxtApellido.ReadOnly = false;
            ktxtApellido.Focus();
        }

        // Evento para editar los datos personales [Correo].
        private void cmdEditarCorreo_Click(object sender, EventArgs e)
        {
            CampoAnterior = ktxtCorreo.Text;

            ktxtCorreo.Enabled = true;
            ktxtCorreo.ReadOnly = false;
            ktxtCorreo.Focus();
        }

        // Evento para editar los datos personales [Contraseña].
        private void cmdEditarContraseña_Click(object sender, EventArgs e)
        {
            CampoAnterior = ktxtContraseña.Text;

            ktxtContraseña.Enabled = true;
            ktxtContraseña.ReadOnly = false;
            ktxtContraseña.Focus();
        }

        // Evento para regresar los datos a su estado original o modificarlos.
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se actualizará el nombre "+ CampoAnterior.ToString() + " a [" + ktxtNombre.Text + "], ¿Está seguro?", "Actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ConexiónBD.ActualizarDatoUsuario(ktxtNombre, ID, 1);
            else ConexiónBD.DesplegarDatosUsuario(ID, ktxtNombre, ktxtApellido, ktxtCorreo, ktxtContraseña);

            ktxtNombre.Enabled = false;
            ktxtNombre.ReadOnly = true;
        }

        // Evento para regresar los datos a su estado original o modificarlos.
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se actualizará el apellido "+ CampoAnterior.ToString() + " a [" + ktxtApellido.Text + "], ¿Está seguro?", "Actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ConexiónBD.ActualizarDatoUsuario(ktxtApellido, ID, 2);
            else ConexiónBD.DesplegarDatosUsuario(ID, ktxtNombre, ktxtApellido, ktxtCorreo, ktxtContraseña);

            ktxtApellido.Enabled = false;
            ktxtApellido.ReadOnly = true;
        }

        // Evento para regresar los datos a su estado original o modificarlos.
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se actualizará el correo "+ CampoAnterior.ToString() + " a [" + ktxtCorreo.Text + "], ¿Está seguro?", "Actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ConexiónBD.ActualizarDatoUsuario(ktxtCorreo, ID, 3);
            else ConexiónBD.DesplegarDatosUsuario(ID, ktxtNombre, ktxtApellido, ktxtCorreo, ktxtContraseña);

            ktxtCorreo.Enabled = false;
            ktxtCorreo.ReadOnly = true;
        }

        // Evento para regresar los datos a su estado original o modificarlos.
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se actualizará la contraseña " + CampoAnterior.ToString() + " a [" + ktxtContraseña.Text + "], ¿Está seguro?", "Actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ConexiónBD.ActualizarDatoUsuario(ktxtContraseña, ID, 4);
            else ConexiónBD.DesplegarDatosUsuario(ID, ktxtNombre, ktxtApellido, ktxtCorreo, ktxtContraseña);

            ktxtContraseña.Enabled = false;
            ktxtContraseña.ReadOnly = true;
        }

        // Evento para modificar la variable global [Horario] #1
        private void tsmHorario1_Click(object sender, EventArgs e)
        {
            Horario = 1;

            // Deshabilitamos el botón.
            ktsmHorario1.Enabled = false;
            ktsmHorario2.Enabled = true;
            ktsmHorario3.Enabled = true;

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);
        }

        // Evento para modificar la variable global [Horario] #2
        private void tsmHorario2_Click(object sender, EventArgs e)
        {
            Horario = 2;

            // Deshabilitamos el botón.
            ktsmHorario1.Enabled = true;
            ktsmHorario2.Enabled = false;
            ktsmHorario3.Enabled = true;

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);
        }

        // Evento para modificar la variable global [Horario] #3
        private void tsmHorario3_Click(object sender, EventArgs e)
        {
            Horario = 3;

            // Deshabilitamos el botón.
            ktsmHorario1.Enabled = true;
            ktsmHorario2.Enabled = true;
            ktsmHorario3.Enabled = false;

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);
        }

        // Evento para modificar la variable global [Dia] #1
        private void tsmLunes_Click(object sender, EventArgs e)
        {
            Dia = 1;

            // Deshabilitamos el botón.
            ktsmLunes.Enabled = false;
            ktsmMartes.Enabled = true;
            ktsmMiércoles.Enabled = true;
            ktsmJueves.Enabled = true;
            ktsmViernes.Enabled = true;
            ktsmSábado.Enabled = true;
            ktsmDomingo.Enabled = true;

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);
        }

        // Evento para modificar la variable global [Dia] #2
        private void tsmMartes_Click(object sender, EventArgs e)
        {
            Dia = 2;

            // Deshabilitamos el botón.
            ktsmLunes.Enabled = true;
            ktsmMartes.Enabled = false;
            ktsmMiércoles.Enabled = true;
            ktsmJueves.Enabled = true;
            ktsmViernes.Enabled = true;
            ktsmSábado.Enabled = true;
            ktsmDomingo.Enabled = true;

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);
        }

        private void kcmdMenuAbrir_Click(object sender, EventArgs e)
        {
            kcmdMenuCerrar.Visible = true;
            kcmdHorario.Visible = true;
            kcmdUsuario.Visible = true;
            kcmdDocente.Visible = true;
            kcmdMateria.Visible = true;
            kcmdMultitarea.Visible = true;
            kchkbModoClaroOscuro.Visible = true;
            kcmdCerrarSesion.Visible = true;
        }

        private void kcmdMenuCerrar_Click(object sender, EventArgs e)
        {
            kcmdMenuCerrar.Visible = false;
            kcmdHorario.Visible = false;
            kcmdUsuario.Visible = false;
            kcmdDocente.Visible = false;
            kcmdMateria.Visible = false;
            kcmdMultitarea.Visible = false;
            kchkbModoClaroOscuro.Visible = false;
            kcmdCerrarSesion.Visible = false;
        }

        // Evento para modificar la variable global [Dia] #3
        private void tsmMiércoles_Click(object sender, EventArgs e)
        {
            Dia = 3;

            // Deshabilitamos el botón.
            ktsmLunes.Enabled = true;
            ktsmMartes.Enabled = true;
            ktsmMiércoles.Enabled = false;
            ktsmJueves.Enabled = true;
            ktsmViernes.Enabled = true;
            ktsmSábado.Enabled = true;
            ktsmDomingo.Enabled = true;

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);
        }

        // Evento para modificar la variable global [Dia] #4
        private void tsmJueves_Click(object sender, EventArgs e)
        {
            Dia = 4;

            // Deshabilitamos el botón.
            ktsmLunes.Enabled = true;
            ktsmMartes.Enabled = true;
            ktsmMiércoles.Enabled = true;
            ktsmJueves.Enabled = false;
            ktsmViernes.Enabled = true;
            ktsmSábado.Enabled = true;
            ktsmDomingo.Enabled = true;

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);
        }

        // Evento para modificar la variable global [Dia] #5
        private void tsmViernes_Click(object sender, EventArgs e)
        {
            Dia = 5;

            // Deshabilitamos el botón.
            ktsmLunes.Enabled = true;
            ktsmMartes.Enabled = true;
            ktsmMiércoles.Enabled = true;
            ktsmJueves.Enabled = true;
            ktsmViernes.Enabled = false;
            ktsmSábado.Enabled = true;
            ktsmDomingo.Enabled = true;

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);
        }

        private void kchkbModoClaroOscuro_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["ModoOscuro"] = kchkbModoClaroOscuro.Checked;
            Settings.Default.Save();
        }

        // Evento para modificar la variable global [Dia] #6
        private void tsmSábado_Click(object sender, EventArgs e)
        {
            Dia = 6;

            // Deshabilitamos el botón.
            ktsmLunes.Enabled = true;
            ktsmMartes.Enabled = true;
            ktsmMiércoles.Enabled = true;
            ktsmJueves.Enabled = true;
            ktsmViernes.Enabled = true;
            ktsmSábado.Enabled = false;
            ktsmDomingo.Enabled = true;

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);
        }

        // Evento para modificar la variable global [Dia] #7
        private void tsmDomingo_Click(object sender, EventArgs e)
        {
            Dia = 7;

            // Deshabilitamos el botón.
            ktsmLunes.Enabled = true;
            ktsmMartes.Enabled = true;
            ktsmMiércoles.Enabled = true;
            ktsmJueves.Enabled = true;
            ktsmViernes.Enabled = true;
            ktsmSábado.Enabled = true;
            ktsmDomingo.Enabled = false;

            // Invocamos el método [DesplegarHorarios].
            ConexiónBD.DesplegarHorario(kdgvHorario, this.ID, Horario, Dia);
            ConexiónBD.DesplegarMateria(kdgvMateria, this.ID, Horario, Dia);
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

        private void kchkbModoClaroOscuro_CheckedChanged(object sender, EventArgs e)
        {
            if (kchkbModoClaroOscuro.CheckState == CheckState.Checked)
                ActivarModoOscuro();

            if (kchkbModoClaroOscuro.CheckState == CheckState.Unchecked)
                ActivarModoClaro();
        }

        // Método para activar [Modo Oscuro]
        public void ActivarModoOscuro()
        {
            Palette = PaletaModoOscuro;
            kpnlContenido.Palette = PaletaModoOscuro;
            kpnlFullDock.Palette = PaletaModoOscuro;

            // Contenedor [Menú]

            kpnlMenu.Palette = PaletaModoOscuro;

            kcmdMenuCerrar.StateNormal.Back.Color1 = Color.DimGray;
            kcmdMenuCerrar.StateNormal.Back.Color2 = Color.DimGray;
            kcmdMenuCerrar.StateCommon.Content.ShortText.Color1 = Color.White;

            kcmdMenuAbrir.StateNormal.Back.Color1 = Color.DimGray;
            kcmdMenuAbrir.StateNormal.Back.Color2 = Color.DimGray;
            kcmdMenuAbrir.StateCommon.Content.ShortText.Color1 = Color.White;

            kcmdHorario.StateNormal.Back.Color1 = Color.DimGray;
            kcmdHorario.StateNormal.Back.Color2 = Color.DimGray;
            kcmdHorario.StateCommon.Content.ShortText.Color1 = Color.White;

            kcmdUsuario.StateNormal.Back.Color1 = Color.DimGray;
            kcmdUsuario.StateNormal.Back.Color2 = Color.DimGray;
            kcmdUsuario.StateCommon.Content.ShortText.Color1 = Color.White;

            kcmdDocente.StateNormal.Back.Color1 = Color.DimGray;
            kcmdDocente.StateNormal.Back.Color2 = Color.DimGray;
            kcmdDocente.StateCommon.Content.ShortText.Color1 = Color.White;

            kcmdMateria.StateNormal.Back.Color1 = Color.DimGray;
            kcmdMateria.StateNormal.Back.Color2 = Color.DimGray;
            kcmdMateria.StateCommon.Content.ShortText.Color1 = Color.White;

            kcmdMultitarea.StateNormal.Back.Color1 = Color.DimGray;
            kcmdMultitarea.StateNormal.Back.Color2 = Color.DimGray;
            kcmdMultitarea.StateCommon.Content.ShortText.Color1 = Color.White;

            kcmdCerrarSesion.StateNormal.Back.Color1 = Color.DimGray;
            kcmdCerrarSesion.StateNormal.Back.Color2 = Color.DimGray;
            kcmdCerrarSesion.StateCommon.Content.ShortText.Color1 = Color.White;

            kcmdMenuCerrar.Palette = PaletaModoOscuro;
            kcmdMenuAbrir.Palette = PaletaModoOscuro;
            kcmdHorario.Palette = PaletaModoOscuro;
            kcmdUsuario.Palette = PaletaModoOscuro;
            kcmdDocente.Palette = PaletaModoOscuro;
            kcmdMateria.Palette = PaletaModoOscuro;
            kcmdMultitarea.Palette = PaletaModoOscuro;
            kcmdCerrarSesion.Palette = PaletaModoOscuro;
            kcmdAgregarDocente.Palette = PaletaModoOscuro;

            // Contenedor [Horario]

            kpnlHorario.Palette = PaletaModoOscuro;
            kpnlHorario.StateNormal.Color1 = Color.DimGray;
            kpnlHorario.StateNormal.Color2 = Color.DimGray;

            kgboxHorario.Palette = PaletaModoOscuro;
            kgboxHorario.StateNormal.Back.Color1 = Color.DimGray;
            kgboxHorario.StateNormal.Back.Color2 = Color.DimGray;

            kmnsHorario.BackColor = Color.DimGray;
            kmnsHorario.ForeColor = Color.Black;
            ktsmHorario1.ForeColor = Color.Black;
            ktsmHorario2.ForeColor = Color.Black;
            ktsmHorario3.ForeColor = Color.Black;
            kmnsHorario.Items[0].BackColor = Color.DimGray;
            kmnsHorario.Items[1].BackColor = Color.DimGray;
            kmnsHorario.Items[2].BackColor = Color.DimGray;
            
            kmnsSemana.BackColor = Color.DimGray;
            kmnsSemana.ForeColor = Color.Black;
            ktsmLunes.ForeColor = Color.Black;
            ktsmMartes.ForeColor = Color.Black;
            ktsmMiércoles.ForeColor = Color.Black;
            ktsmJueves.ForeColor = Color.Black;
            ktsmViernes.ForeColor = Color.Black;
            ktsmSábado.ForeColor = Color.Black;
            ktsmDomingo.ForeColor = Color.Black;
            kmnsSemana.Items[0].BackColor = Color.DimGray;
            kmnsSemana.Items[1].BackColor = Color.DimGray;
            kmnsSemana.Items[2].BackColor = Color.DimGray;

            kgboxHorario.Panel.BackColor = Color.DimGray;

            kgboxSemana.Palette = PaletaModoOscuro;

            kgboxSemana.StateNormal.Back.Color1 = Color.DimGray;
            kgboxSemana.StateNormal.Back.Color2 = Color.DimGray;

            kdgvHorario.Palette = PaletaModoOscuro;
            kdgvHorario.StateNormal.Background.Color1 = Color.DimGray;

            // Contenedor [Materia]

            kpnlMateria.Palette = PaletaModoOscuro;

            kgboxMateria.Palette = PaletaModoOscuro;
            kgboxMateria.StateNormal.Back.Color1 = Color.DimGray;
            kgboxMateria.StateNormal.Back.Color2 = Color.DimGray;

            kpnlMateria.BackColor = Color.DimGray;

            kdgvMateria.Palette = PaletaModoOscuro;
            kdgvMateria.StateNormal.Background.Color1 = Color.DimGray;

            // Contenedor [Docente]

            kpnlDocente.Palette = PaletaModoOscuro;

            kgboxDocente.Palette = PaletaModoOscuro;
            kgboxDocente.StateNormal.Back.Color1 = Color.DimGray;
            kgboxDocente.StateNormal.Back.Color2 = Color.DimGray;

            kdgvDocente.Palette = PaletaModoOscuro;
            kdgvDocente.StateNormal.Background.Color1 = Color.DimGray;

            kcmdAgregarDocente.Palette = PaletaModoOscuro;
            kcmdAgregarDocente.StateNormal.Back.Color1 = Color.DimGray;
            kcmdAgregarDocente.StateNormal.Back.Color2 = Color.DimGray;
            kcmdAgregarDocente.StateCommon.Content.ShortText.Color1 = Color.White;

            // Contenedor [Usuario]

            kpnlUsuario.Palette = PaletaModoOscuro;
            kgboxUsuario.Palette = PaletaModoOscuro;
            
            kgboxUsuario.StateNormal.Back.Color1 = Color.DimGray;
            kgboxUsuario.StateNormal.Back.Color2 = Color.DimGray;

            ktxtNombre.Palette = PaletaModoOscuro;
            ktxtNombre.StateCommon.Content.Color1 = Color.White;
            ktxtApellido.Palette = PaletaModoOscuro;
            ktxtApellido.StateCommon.Content.Color1 = Color.White;
            ktxtCorreo.Palette = PaletaModoOscuro;
            ktxtCorreo.StateCommon.Content.Color1 = Color.White;
            ktxtContraseña.Palette = PaletaModoOscuro;
            ktxtContraseña.StateCommon.Content.Color1 = Color.White;

            kcmdEditarNombre.Palette = PaletaModoOscuro;
            kcmdEditarApellido.Palette = PaletaModoOscuro;
            kcmdEditarCorreo.Palette = PaletaModoOscuro;
            kcmdEditarContraseña.Palette = PaletaModoOscuro;
        }

        // Método para desactivar [Modo Oscuro]
        public void ActivarModoClaro()
        {
            Palette = PaletaModoClaro;
            kcmdHorario.Palette = PaletaModoClaro;
            kpnlContenido.Palette = PaletaModoClaro;
            kpnlFullDock.Palette = PaletaModoClaro;

            // Contenedor [Menú]
            kpnlMenu.Palette = PaletaModoClaro;

            kcmdMenuCerrar.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdMenuCerrar.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdMenuCerrar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            kcmdMenuAbrir.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdMenuAbrir.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdMenuAbrir.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            kcmdHorario.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdHorario.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdHorario.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            kcmdUsuario.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdUsuario.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdUsuario.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            kcmdDocente.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdDocente.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdDocente.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            kcmdMateria.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdMateria.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdMateria.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            kcmdMultitarea.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdMultitarea.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdMultitarea.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            kcmdCerrarSesion.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdCerrarSesion.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdCerrarSesion.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            // Contenedor [Horario]

            kpnlHorario.Palette = PaletaModoClaro;
            kpnlHorario.StateNormal.Color1 = Color.FromArgb(250, 252, 252);
            kpnlHorario.StateNormal.Color2 = Color.FromArgb(250, 252, 252);

            kgboxHorario.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kgboxHorario.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);

            kmnsHorario.BackColor = Color.FromArgb(250, 252, 252);
            kmnsHorario.ForeColor = Color.FromArgb(250, 252, 252);
            ktsmHorario1.ForeColor = Color.FromArgb(8, 142, 254);
            ktsmHorario2.ForeColor = Color.FromArgb(8, 142, 254);
            ktsmHorario3.ForeColor = Color.FromArgb(8, 142, 254);
            kmnsHorario.Items[0].BackColor = Color.FromArgb(250, 252, 252);
            kmnsHorario.Items[1].BackColor = Color.FromArgb(250, 252, 252);
            kmnsHorario.Items[2].BackColor = Color.FromArgb(250, 252, 252);

            kmnsSemana.BackColor = Color.FromArgb(250, 252, 252);
            kmnsSemana.ForeColor = Color.FromArgb(8,142,254);
            ktsmLunes.ForeColor = Color.FromArgb(8,142,254);
            ktsmMartes.ForeColor = Color.FromArgb(8,142,254);
            ktsmMiércoles.ForeColor = Color.FromArgb(8,142,254);
            ktsmJueves.ForeColor = Color.FromArgb(8,142,254);
            ktsmViernes.ForeColor = Color.FromArgb(8,142,254);
            ktsmSábado.ForeColor = Color.FromArgb(8,142,254);
            ktsmDomingo.ForeColor = Color.FromArgb(8,142,254);
            kmnsSemana.Items[0].BackColor = Color.FromArgb(250, 252, 252);
            kmnsSemana.Items[1].BackColor = Color.FromArgb(250, 252, 252);
            kmnsSemana.Items[2].BackColor = Color.FromArgb(250, 252, 252);

            kgboxHorario.Panel.BackColor = Color.FromArgb(250, 252, 252);

            kgboxSemana.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kgboxSemana.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);

            kdgvHorario.Palette = PaletaModoClaro;
            kdgvHorario.StateNormal.Background.Color1 = Color.FromArgb(250,252,252);

            // Contenedor [Materia]

            kpnlMateria.Palette = PaletaModoClaro;

            kgboxMateria.Palette = PaletaModoClaro;
            kgboxMateria.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kgboxMateria.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);

            kdgvMateria.Palette = PaletaModoClaro;
            kdgvMateria.StateNormal.Background.Color1 = Color.FromArgb(250, 252, 252);

            // Contenedor [Docente]

            kpnlDocente.Palette = PaletaModoClaro;

            kgboxDocente.Palette = PaletaModoClaro;
            kgboxDocente.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kgboxDocente.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);

            kdgvDocente.Palette = PaletaModoClaro;
            kdgvDocente.StateNormal.Background.Color1 = Color.FromArgb(250,252,252);

            kcmdAgregarDocente.Palette = PaletaModoClaro;
            kcmdAgregarDocente.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdAgregarDocente.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdAgregarDocente.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            // Contenedor [Usuario]

            kpnlUsuario.Palette = PaletaModoClaro;
            kgboxUsuario.Palette = PaletaModoClaro;

            kgboxUsuario.StateNormal.Back.Color1 = Color.FromArgb(250,252,252);
            kgboxUsuario.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);

            ktxtNombre.Palette = PaletaModoClaro;
            ktxtNombre.StateCommon.Content.Color1 = Color.DimGray;
            ktxtApellido.Palette = PaletaModoClaro;
            ktxtApellido.StateCommon.Content.Color1 = Color.DimGray;
            ktxtCorreo.Palette = PaletaModoClaro;
            ktxtCorreo.StateCommon.Content.Color1 = Color.DimGray;
            ktxtContraseña.Palette = PaletaModoClaro;
            ktxtContraseña.StateCommon.Content.Color1 = Color.DimGray;

            kcmdEditarNombre.Palette = PaletaModoClaro;
            kcmdEditarApellido.Palette = PaletaModoClaro;
            kcmdEditarCorreo.Palette = PaletaModoClaro;
            kcmdEditarContraseña.Palette = PaletaModoClaro;
        }
    }
}
