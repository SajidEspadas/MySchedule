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
        static readonly string Servidor = "pc.axolotlteam.com";
        static readonly string bd = "MyScheduleDB";
        static readonly string Usuario = "sajid";
        static readonly string Password = "";

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
                string T_SQL = string.Format("EXEC InsertarUsuario '{0}', '{1}', '{2}', '{3}'", NuevoUsuario.Nombre, NuevoUsuario.Apellido, NuevoUsuario.Correo, NuevoUsuario.Contraseña);

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

        // Método para obtener el [ID_Usuario].
        public static int ObtenerID(TextBox txtCorreo, TextBox txtContraseña)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                // Variable para almacenar comando [T-SQL].
                string T_SQL = string.Format("SELECT Usuario.ID_Usuario FROM Usuario WHERE Usuario.Usu_Correo = @Usu_Correo AND Usuario.Usu_Contra = @Usu_Contra");                    
                int ObtenerID = 0;

                try
                {
                    // Generamos el comando [T-SQL].
                    SqlCommand Comando = new SqlCommand(T_SQL, Conexión);

                    // Agregamos valor a los parámetros.
                    Comando.Parameters.AddWithValue("@Usu_Correo", txtCorreo.Text);
                    Comando.Parameters.AddWithValue("@Usu_Contra", txtContraseña.Text);

                    // Leemos el comando.
                    SqlDataReader Consulta = Comando.ExecuteReader();

                    // Asignamos el vamos del [ID_Usuario] a la variable [ObtenerID].
                    if (Consulta.Read())
                        ObtenerID = Convert.ToInt32(Consulta["ID_Usuario"]);

                    return ObtenerID;
                }
                catch (SqlException e)
                {
                    Program.MensajeError("Obtención del ID", "Hubo un fallo al momento de obtener su ID " + e.ToString());
                    return 0;
                }
            }

        }

        // Método para generar los espacios de los horarios que podrá utilizar el usuario.
        internal static void GenerarHorariosUsuarioNuevo(int ID)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                string T_SQL = string.Format("EXEC GenerarEspacioDeHorarios @ID_Usuario");

                try
                {
                    SqlCommand Comando = new SqlCommand(T_SQL, Conexión);

                    Comando.Parameters.AddWithValue("@ID_Usuario", ID.ToString());

                    Comando.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Program.MensajeError("", " " + e.ToString());
                }
            }
        }

        internal static void ActualizarDatoUsuario(TextBox txtEditado, int ID, int Caso)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                switch (Caso)
                {
                    case 1:
                        string T_SQL1 = string.Format("UPDATE Usuario SET Usu_Nom=@Nom WHERE Usuario.ID_Usuario = @ID");

                        // Generamos el tsql
                        SqlCommand Comando1 = new SqlCommand(T_SQL1,Conexión);

                        // Agregamos los datos de los parámetros.
                        Comando1.Parameters.AddWithValue("@Nom", txtEditado.Text);
                        Comando1.Parameters.AddWithValue("@ID", ID.ToString());

                        Comando1.ExecuteNonQuery();

                        break;

                    case 2:
                        string T_SQL2 = string.Format("UPDATE Usuario SET Usu_Ape=@Ape WHERE Usuario.ID_Usuario = @ID");

                        // Generamos el tsql
                        SqlCommand Comando2 = new SqlCommand(T_SQL2, Conexión);

                        // Agregamos los datos de los parámetros.
                        Comando2.Parameters.AddWithValue("@Ape", txtEditado.Text);
                        Comando2.Parameters.AddWithValue("@ID", ID.ToString());

                        Comando2.ExecuteNonQuery();

                        break;

                    case 3:
                        string T_SQL3 = string.Format("UPDATE Usuario SET Usu_Correo=@Correo WHERE Usuario.ID_Usuario = @ID");

                        // Generamos el tsql
                        SqlCommand Comando3 = new SqlCommand(T_SQL3, Conexión);

                        // Agregamos los datos de los parámetros.
                        Comando3.Parameters.AddWithValue("@Correo", txtEditado.Text);
                        Comando3.Parameters.AddWithValue("@ID", ID.ToString());

                        Comando3.ExecuteNonQuery();

                        break;

                    case 4:
                        string T_SQL4 = string.Format("UPDATE Usuario SET Usu_Contra=@Contra WHERE Usuario.ID_Usuario = @ID");

                        // Generamos el tsql
                        SqlCommand Comando4 = new SqlCommand(T_SQL4, Conexión);

                        // Agregamos los datos de los parámetros.
                        Comando4.Parameters.AddWithValue("@Contra", txtEditado.Text);
                        Comando4.Parameters.AddWithValue("@ID", ID.ToString());

                        Comando4.ExecuteNonQuery();

                        break;

                }
            }
        }

        // Función validar la existencia del usuario en la base de datos.
        public static bool ValidarInicioDeSesion(TextBox txtCorreo, TextBox txtContraseña)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                // Variable para almacenar comando [T-SQL].
                string T_SQL = @"SELECT COUNT(*) FROM Usuario WHERE Usuario.Usu_Correo = @Usu_Correo AND Usuario.Usu_Contra = @Usu_Contra";

                try
                {
                    // Generamos el comando [T-SQL].
                    SqlCommand Comando = new SqlCommand(T_SQL, Conexión);

                    // Agregamos valor a los parámetros.
                    Comando.Parameters.AddWithValue("@Usu_Correo",txtCorreo.Text);
                    Comando.Parameters.AddWithValue("@Usu_Contra", txtContraseña.Text);

                    // Retornamos el valor de las filas afectadas.
                    return Convert.ToBoolean(Comando.ExecuteScalar());
                }
                catch (SqlException e)
                {
                    Program.MensajeError("Validar Datos", "Hubo un fallo al momento de validar los datos ingresados " + e.ToString());
                    return false;
                }
            }
        }

        // Función para iniciar sesión.
        public static int InicioDeSesion(TextBox txtCorreo, TextBox txtContraseña)
        {
            string T_SQL = @"SELECT ID_Usuario FROM Usuario WHERE Usuario.Usu_Correo = @Usu_Correo AND Usuario.Usu_Contra = @Usu_Contra", ID = "";

            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                try
                {
                    // Generamos el comando [T-SQL].
                    SqlCommand Comando = new SqlCommand(T_SQL, Conexión);

                    // Agregamos valor a los parámetros.
                    Comando.Parameters.AddWithValue("@Usu_Correo", txtCorreo.Text);
                    Comando.Parameters.AddWithValue("@Usu_Contra", txtContraseña.Text);

                    // Leemos el comando.
                    SqlDataReader Consulta = Comando.ExecuteReader();

                    // Asignamos el vamos del [ID_Usuario] a la variable [ID].
                    if (Consulta.Read())
                        ID = Consulta["ID_Usuario"].ToString();

                    ;

                    // Retornamos [ID].
                    return Convert.ToInt32(ID);
                }
                catch (SqlException e)
                {
                    Program.MensajeError("Error al iniciar sesión", "Hubo un error al iniciar su sesión, por favor vuelva a intentarlo..." + e.ToString());
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

        // WIP
        public static void DesplegarDatosUsuario(int ID, TextBox txtNombre, TextBox txtApellido, TextBox txtCorreo, TextBox txtContraseña)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                string T_SQL = string.Format(@"SELECT * FROM Usuario WHERE Usuario.ID_Usuario = @ID");

                try
                {
                    // Generamos el comando [T-SQL].
                    SqlCommand Comando = new SqlCommand(T_SQL, Conexión);

                    // Agregamos valor a los parámetros.
                    Comando.Parameters.AddWithValue("@ID", ID.ToString());

                    // Leemos el comando.
                    SqlDataReader Consulta = Comando.ExecuteReader();

                    // Asignamos el vamos del [ID_Usuario] a la variable [ID].
                    if (Consulta.Read())
                    {
                        txtNombre.Text = Consulta["Usu_Nom"].ToString();
                        txtApellido.Text = Consulta["Usu_Ape"].ToString();
                        txtCorreo.Text = Consulta["Usu_Correo"].ToString();
                        txtContraseña.Text = Consulta["Usu_Contra"].ToString();
                    }

                }
                catch (SqlException e)
                {

                }
            }
        }

        // WIP
        //public static int GuardarRecordatorio(TextBox txtFechaInicio, DateTimePicker dtpFechaFin, TextBox txtNombreRecordatorio, TextBox txtComentario)
        //{
        //    // Modificamos el formato del [DateTimePicker].
        //    dtpFechaFin.CustomFormat = "yyyy-MM-dd";

        //    using (SqlConnection Conexión = ConexiónBD.ConectarBD())
        //    {
        //        // Falta agregar el ID del usuario.
        //        string T_SQL = String.Format(@"INSERT INTO Recordatorio VALUES( '{0}', '{1}', '{2}', '{3}')", txtFechaInicio.Text, dtpFechaFin.Value.ToString(), txtNombreRecordatorio.Text, txtComentario.Text);

        //        try
        //        {
        //            SqlCommand Comando = new SqlCommand(T_SQL, Conexión);

        //            return 1;
        //        }
        //        catch (SqlException e)
        //        {
        //            return 0;
        //        }
        //    }
        //}

        //internal static void DesplegarHorarios(string ID, DataGridView dgvHorario, int horario, int dia, int hora)
        //{
        //    using (SqlConnection Conexión = ConexiónBD.ConectarBD())
        //    {
        //        string T_SQL = @"SELECT";

        //        try
        //        {
        //            SqlCommand Comando = new SqlCommand(T_SQL, Conexión);

        //            dgvHorario.DataSource.
        //        }
        //        catch (SqlException e)
        //        {

        //        }
        //    }
        //}
    }
}
