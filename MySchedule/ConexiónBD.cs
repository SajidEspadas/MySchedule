using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Librería necesaria para la conexión a la base de datos.
using System.Data.SqlClient; // Librería necesaria para la conexión a la base de datos.

namespace MySchedule
{
    // Creamos la clase [ConexiónBD].
    class ConexiónBD
    {
        // Generamos una nueva instancia de la clase [SqlConnection].
        SqlConnection Conexión = new SqlConnection();

        // Declaramos los parámetros para nuestra [CadenaConexión].
        static string Servidor = @"LAPTOP-58M9B2VK\VENTAS";
        static string bd = "MySchedule_DB";
        static string Usuario = "Alvaro";
        static string Password = "contrasena123";
        static string Puerto = "1433";

        // Concatenamos la [CadenaConexión].
        static string CadenaConexión = "Data Source=" + Servidor + ";User Id=" + Usuario + ";Password =" + Password + ";Initial Catalog=" + bd + ";";

        // Creamos constructor de la clase[ConexiónBD].
        public ConexiónBD()
        {
            Conexión.ConnectionString = CadenaConexión;
        }

        // Método para abrir la base de datos.
        public void ConectarBD()
        {
            // Try Catch para realizar la conexión con la base de datos.
            try
            {
                // Abrimos la base de datos.
                Conexión.Open();
            }
            catch (SqlException e)
            {
                Program.MensajeError("Conexión a la base de datos", "Ocurrió un error al intentar conectarse a la base de datos... " + e.ToString());
            }
        }

        public void DesconectarBD()
        {
            // Cerramos la base de datos.
            Conexión.Close();
        }

        //// Creamos el método [DesconectarBD].
        //public SqlConnection DesconectarBD()
        //{
        //    try
        //    {
        //        // Agregamos la cadena de conexión
        //        Conexión.ConnectionString = CadenaConexión;

        //        // Cerramos la base de datos.
        //        Conexión.Close();

        //    }
        //    catch (SqlException e)
        //    {
        //        Program.MensajeError("Conexión", "Hubo un error al intentar desconectarse de la base de datos...\n" + e.ToString());
        //    }

        //    // Retornamos la [Conexión].
        //    return Conexión;

        //    //// Establecemos el nombre del servidor, la base de datos a utilizar y su seguridad.
        //    //SqlConnection cn = new SqlConnection(@"SERVER=LAPTOP-58M9B2VK\VENTAS;DATABASE=MySchedule_BD;Integrated security=true");

        //    //// Cerramos la conexión con la base de datos.
        //    //cn.Close();

        //    //// Retornamos la conexión.
        //    //return cn;
        //}

        // Función para insertar [Usuario].
        public static int InsertarUsuario(Usuario NuevoUsuario)
        {
            try
            {
                // Generamos el comando [T-SQL].
                SqlCommand Comando = new SqlCommand
                (
                    string.Format("EXEC Proc_InsertarUsuario '{0}', '{1}', '{2}', '{3}';", NuevoUsuario.Usu_Nombre, NuevoUsuario.Usu_Apellido, NuevoUsuario.Usu_Correo, NuevoUsuario.Usu_Contraseña)
                );

                return Comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Program.MensajeError("Inserción de los datos", "Hubo un fallo en la inserción de los datos");
                return 0;
            }
        }

        // Función para insertar [Usuario].
    }
}
