using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Librería necesaria para la conexión a la base de datos.
using System.Data.SqlClient; // Librería necesaria para la conexión a la base de datos.
using System.Windows.Forms; // Librería necesaria para pasar [TextBox] como parámetro.

namespace MySchedule
{
    // Creamos la clase [ConexiónBD].
    class ConexiónBD
    {
        // Declaramos los parámetros para nuestra [CadenaConexión].
        static readonly string Servidor = "LAPTOP-58M9B2VK";
        static readonly string bd = "MyScheduleDB";
        static readonly string Usuario = "sa";
        static readonly string Password = "12345";

        // Concatenamos la [CadenaConexión].
        static readonly string CadenaConexión = "Data Source=" + Servidor + ";User Id=" + Usuario + ";Password =" + Password + ";Initial Catalog=" + bd + ";";

        // Generamos una nueva instancia de la clase [SqlConnection].
        readonly SqlConnection Conexión = new SqlConnection();

        // Creamos constructor de la clase [ConexiónBD].
        public ConexiónBD()
        {
            Conexión.ConnectionString = CadenaConexión;
        }

        public static SqlConnection ConectarBD()
        {
            // Adjuntamos la [CadenaConexión] a la nueva instancia [EstadoConexión].
            SqlConnection EstadoConexión = new SqlConnection(CadenaConexión);

            // Abrimos la conexión.
            EstadoConexión.Open();

            // Retornamos el [EstadoConexión].
            return EstadoConexión;
        }

        public static SqlConnection DesconectarBD()
        {
            // Adjuntamos la [CadenaConexión] a la nueva instancia [EstadoConexión].
            SqlConnection EstadoConexión = new SqlConnection(CadenaConexión);

            // Abrimos la conexión.
            EstadoConexión.Close();

            // Retornamos el [EstadoConexión].
            return EstadoConexión;
        }

        // Función para insertar [Usuario].
        public static int InsertarUsuario(Usuario NuevoUsuario)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                // Variable para almacenar comando [T-SQL].
                string T_SQL = string.Format("EXEC Proc_InsertarUsuario '{0}', '{1}', '{2}', '{3}'", NuevoUsuario.Nombre, NuevoUsuario.Apellido, NuevoUsuario.Correo, NuevoUsuario.Contraseña);

                try
                {
                    // Generamos el comando [T-SQL].
                    SqlCommand Comando = new SqlCommand(string.Format(T_SQL), Conexión);

                    // Ejecutamos el comanto [T-SQL].
                    return Comando.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Program.MensajeError("Inserción de los datos", "Hubo un fallo en la inserción de los datos " + e.ToString());
                    return 0;
                }
            }
        }

        // Función para verificar si existe el [Correo] en la base de datos.
        public static bool VerificarCorreoBD(TextBox txtCorreo)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                // Variable para almacenar comando [T-SQL].
                string T_SQL = @"SELECT COUNT(*) FROM Usuario WHERE Usu_Correo = @Usu_Correo";

                try
                {
                    // Generamos el comando [T-SQL].
                    SqlCommand Comando = new SqlCommand(T_SQL, Conexión);

                    // Agregamos el contenido a [@txtCorreo.Text].
                    Comando.Parameters.AddWithValue("@Usu_Correo", txtCorreo.Text);

                    // Verificamos si existe el [Correo].
                    int Count = Convert.ToInt32(Comando.ExecuteScalar());

                    return Count == 1;

                }
                catch (SqlException e)
                {
                    return Program.MensajeError("Verificación del correo", "Hubo un fallo al momento de verificar el correo en la base de datos " + e.ToString()); ;
                }
            }
        }
    }
}
