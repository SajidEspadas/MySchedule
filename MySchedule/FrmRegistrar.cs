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
    public partial class FrmRegistrar : Form
    {

        public FrmRegistrar()
        {
            InitializeComponent();
        }

        // || ============================================================================= || //

        // ===== [ INICIO MÉTODOS ] ===== //

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
            // WIP
        }

        // ===== [ FIN EVENTOS ] ===== //

        // || ============================================================================= || //
    }
}
