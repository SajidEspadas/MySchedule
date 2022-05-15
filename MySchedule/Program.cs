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
    }

    // Clase [Usuario].
    public class Usuario
    {
        // Campos de la clase [Usuario].
        public string Usu_Nombre { get; set; }
        public string Usu_Apellido { get; set; }
        public string Usu_Correo { get; set; }
        public string Usu_Contraseña { get; set; }

        // Constructor básico.
        public Usuario() { }

        // Constructor para capturar los datos.
        public Usuario(string Nombre, string Apellido, string Correo, string Contraseña)
        {
            Usu_Nombre = Nombre;
            Usu_Apellido = Apellido;
            Usu_Correo = Correo;
            Usu_Contraseña = Contraseña;
        }

        // Función para insertar los datos.
        //public int InsertarDatos(Usuario Registrar)
        //{
        //    using (SqlConnection cn = new SqlConnection)
        //    {
        //        return 0;
        //    }
            
        //}
    }
}
