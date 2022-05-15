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

        // ===== [ FIN EVENTOS ] ===== //

        // || ============================================================================= || //
    }
}
