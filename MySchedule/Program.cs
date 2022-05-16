using System;
using System.Collections.Generic;
using System.Data.SqlClient; // Librería necesaria.
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchedule
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmIniciarSesion());
        }

        // Método para desplegar advertencia de error.
        public static bool MensajeError(string Espacio, string Descripción)
        {
            // Establecemos el encabezado del [MessageBox].
            string Título = "Hubo un error en " + Espacio;

            // Mostramos [MessageBox].
            MessageBox.Show(Descripción, Título);

            // Retornamos valor [bool].
            return false;
        }
    }
}