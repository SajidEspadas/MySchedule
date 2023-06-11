using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Librería necesaria para la conexión a la base de datos.
using System.Data.SqlClient; // Librería necesaria para la conexión a la base de datos.
using System.Windows.Forms; // Librería necesaria para pasar [TextBox] como parámetro.
using ComponentFactory.Krypton.Toolkit;

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
        public static int ObtenerID(KryptonTextBox txtCorreo, KryptonTextBox txtContraseña)
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

        // Función para iniciar sesión.
        public static int InicioDeSesion(KryptonTextBox txtCorreo, KryptonTextBox txtContraseña)
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

        // Método para verificar que el campo [Mat_Activa] esa 1 o 0.
        internal static bool VerificarMat_Activa(int iD, int horario, int dia, int hora)
        {
            MyScheduleDataSetTableAdapters.QueriesTableAdapter MateriaMat_MatActiva = new MyScheduleDataSetTableAdapters.QueriesTableAdapter();

            int Activa = (int)MateriaMat_MatActiva.ObtenerMat_Activa(iD, horario, dia, hora);

            if (Activa == 1)
                return true;
            else return false;
        }

        // Función para verificar si existe el [Correo] en la base de datos.
        public static bool VerificarCorreoBD(KryptonTextBox txtCorreo)
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

        internal static void ActualizarDocente(int iDDocTemp, KryptonTextBox txtNombreDocente, KryptonTextBox txtApellidoDocente, KryptonTextBox txtCorreoDocente, KryptonTextBox txtTelefonoDocente)
        {
            MyScheduleDataSetTableAdapters.QueriesTableAdapter Actualizar = new MyScheduleDataSetTableAdapters.QueriesTableAdapter();
            //MessageBox.Show(txtNombreDocente.Text + "\n" + txtApellidoDocente.Text + "\n" + txtCorreoDocente.Text + "\n" + txtTelefonoDocente.Text + "\n" + iDDocTemp.ToString(), "DATOS"); ;
            Actualizar.ActualizarDocente(txtNombreDocente.Text, txtApellidoDocente.Text, txtCorreoDocente.Text, txtTelefonoDocente.Text, iDDocTemp);
        }

        // Método para obtener el ID del docente a eliminar.
        internal static int ObtenerIDDocente(int iD, string nombreTemp, string apellidoTemp, string correoTemp, string telefonoTemp)
        {
            MyScheduleDataSetTableAdapters.QueriesTableAdapter Obtener = new MyScheduleDataSetTableAdapters.QueriesTableAdapter();

            return (int)Obtener.ObtenerIDDocente(iD, nombreTemp.Trim(), apellidoTemp.Trim(), correoTemp.Trim(), telefonoTemp.Trim());
        }

        internal static void ActualizarDatoUsuario(KryptonTextBox txtEditado, int ID, int Caso)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                switch (Caso)
                {
                    case 1:
                        // Variable para almacenar comando [T-SQL].
                        string T_SQL1 = string.Format("UPDATE Usuario SET Usu_Nom=@Nom WHERE Usuario.ID_Usuario = @ID");

                        // Generamos el comando [T-SQL].
                        SqlCommand Comando1 = new SqlCommand(T_SQL1, Conexión);

                        // Agregamos los datos de los parámetros.
                        Comando1.Parameters.AddWithValue("@Nom", txtEditado.Text);
                        Comando1.Parameters.AddWithValue("@ID", ID.ToString());

                        Comando1.ExecuteNonQuery();

                        break;

                    case 2:
                        // Variable para almacenar comando [T-SQL].
                        string T_SQL2 = string.Format("UPDATE Usuario SET Usu_Ape=@Ape WHERE Usuario.ID_Usuario = @ID");

                        // Generamos el comando [T-SQL].
                        SqlCommand Comando2 = new SqlCommand(T_SQL2, Conexión);

                        // Agregamos los datos de los parámetros.
                        Comando2.Parameters.AddWithValue("@Ape", txtEditado.Text);
                        Comando2.Parameters.AddWithValue("@ID", ID.ToString());

                        Comando2.ExecuteNonQuery();

                        break;

                    case 3:
                        // Variable para almacenar comando [T-SQL].
                        string T_SQL3 = string.Format("UPDATE Usuario SET Usu_Correo=@Correo WHERE Usuario.ID_Usuario = @ID");

                        // Generamos el comando [T-SQL].
                        SqlCommand Comando3 = new SqlCommand(T_SQL3, Conexión);

                        // Agregamos los datos de los parámetros.
                        Comando3.Parameters.AddWithValue("@Correo", txtEditado.Text);
                        Comando3.Parameters.AddWithValue("@ID", ID.ToString());

                        Comando3.ExecuteNonQuery();

                        break;

                    case 4:
                        // Variable para almacenar comando [T-SQL].
                        string T_SQL4 = string.Format("UPDATE Usuario SET Usu_Contra=@Contra WHERE Usuario.ID_Usuario = @ID");

                        // Generamos el comando [T-SQL].
                        SqlCommand Comando4 = new SqlCommand(T_SQL4, Conexión);

                        // Agregamos los datos de los parámetros.
                        Comando4.Parameters.AddWithValue("@Contra", txtEditado.Text);
                        Comando4.Parameters.AddWithValue("@ID", ID.ToString());

                        Comando4.ExecuteNonQuery();

                        break;

                }
            }
        }

        // Método para agregar materia al [pnlHorario].
        internal static void ActualizarMateria(KryptonTextBox txtNombreMateria, KryptonTextBox txtComentarioMateria, KryptonTextBox txtNombreAulaMateria, int Horario, int Dia, int Hora, int iD)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                // Variable para almacenar comando [T-SQL].
                string T_SQL1 = string.Format("UPDATE   Materia     SET     Mat_Nom = @NombreMateria,   Mat_Coment = @ComentarioMateria,    Aula_Nom = @NombreAula, Mat_Activa = 1  FROM Materia    WHERE Materia.ID_Usuario = @ID  AND Materia.ID_Horario = @Horario   AND Materia.ID_Dia = @Dia   AND Materia.ID_Hora = @Hora");

                try
                {
                    // Generamos el comando [T-SQL].
                    SqlCommand Comando1 = new SqlCommand(T_SQL1, Conexión);
                    //SqlCommand Comando2 = new SqlCommand(T_SQL2, Conexión);

                    // Agregamos los datos de los parámetros.
                    Comando1.Parameters.AddWithValue("@NombreMateria", txtNombreMateria.Text);
                    Comando1.Parameters.AddWithValue("@ComentarioMateria", txtComentarioMateria.Text);
                    Comando1.Parameters.AddWithValue("@NombreAula", txtNombreAulaMateria.Text);
                    Comando1.Parameters.AddWithValue("@ID", iD.ToString());
                    Comando1.Parameters.AddWithValue("@Horario", Horario.ToString());
                    Comando1.Parameters.AddWithValue("@Dia", Dia.ToString());
                    Comando1.Parameters.AddWithValue("@Hora", Hora.ToString());

                    // Ejecutamos la consulta.
                    Comando1.ExecuteNonQuery();
                }
                catch
                {

                }
            }
        }

        // Función validar la existencia del usuario en la base de datos.
        public static bool ValidarInicioDeSesion(KryptonTextBox txtCorreo, KryptonTextBox txtContraseña)
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
                    Comando.Parameters.AddWithValue("@Usu_Correo", txtCorreo.Text);
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

        public static void DesplegarDatosUsuario(int ID, KryptonTextBox txtNombre, KryptonTextBox txtApellido, KryptonTextBox txtCorreo, KryptonTextBox txtContraseña)
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
                    Program.MensajeError("Desplegar datos", "Hubo un fallo al momento de desplegar sus datos personales " + e.ToString());
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

        internal static void DesplegarHorario(DataGridView dgvHorario, int iD, int horario, int dia)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                // Generamos una nueva instancia de la clase [dgvHorarioTableAdapter] para desplegar el horario del usuario.
                MyScheduleDataSetTableAdapters.dgvHorarioTableAdapter dgvHorario1 = new MyScheduleDataSetTableAdapters.dgvHorarioTableAdapter();

                // Obtenemos los datos de la consulta.
                MyScheduleDataSet.dgvHorarioDataTable Consulta = dgvHorario1.DesplegarHorario(iD, horario, dia);
                
                // Desplegamos los datos en el [dgvHorario].
                dgvHorario.DataSource = Consulta;
            }
        }

        // Método para "Eliminar" (Volver a su estado inicial) una materia.
        internal static void EliminarMateria(int iD, int horario, int dia, int hora)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                string T_SQL = string.Format("UPDATE Materia SET Mat_Nom = 'Presione para ingresar una materia', Mat_Coment = 'Agregar comentario', Aula_Nom = 'Agregar aula', Mat_Activa = 0 WHERE Materia.ID_Usuario = @ID AND Materia.ID_Horario = @Horario AND Materia.ID_Dia = @Dia AND Materia.ID_Hora = @Hora");

                // Generamos el comando [T-SQL].
                SqlCommand Comando = new SqlCommand(T_SQL, Conexión);

                // Agregamos valor a los parámetros.
                Comando.Parameters.AddWithValue("@ID", iD);
                Comando.Parameters.AddWithValue("@Horario", horario);
                Comando.Parameters.AddWithValue("@Dia", dia);
                Comando.Parameters.AddWithValue("@Hora", hora);

                Comando.ExecuteNonQuery();
            }
        }

        // Método para desplegar los docentes en el [dgvDocente].
        internal static void DesplegarDocente(DataGridView dgvDocente, int iD)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                // Generamos una nueva instancia de la clase [dgvHorarioTableAdapter] para desplegar el horario del usuario.
                MyScheduleDataSetTableAdapters.dgvDocenteTableAdapter dgvDocente1 = new MyScheduleDataSetTableAdapters.dgvDocenteTableAdapter();

                // Obtenemos los datos de la consulta.
                MyScheduleDataSet.dgvDocenteDataTable Consulta = dgvDocente1.DesplegarDocente(iD);

                // Desplegamos los datos en el [dgvDocente].
                dgvDocente.DataSource = Consulta;
            }
        }

        // Método para insertar los datos de un nuevo docente.
        internal static void InsertarDocente(int iD, KryptonTextBox txtNombreDocente, KryptonTextBox txtApellidoDocente, KryptonTextBox txtCorreoDocente, KryptonTextBox txtTelefonoDocente)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                //string T_SQL = string.Format("INSERT INTO Docente VALUES(@ID, @DocNom, @DocApe, @DocCor, @DocTel)");

                //MessageBox.Show("cuarta prueba dentro del metodo inserta docente" + "\n" + iD.ToString(), "4");

                //// Generamos el comando [T-SQL].
                //SqlCommand Comando = new SqlCommand(T_SQL, Conexión);

                //// Agregamos valor a los parámetros.
                //Comando.Parameters.AddWithValue("@ID", iD.ToString());
                //Comando.Parameters.AddWithValue("@DocNom", txtNombreDocente.Text);
                //Comando.Parameters.AddWithValue("@DocApe", txtApellidoDocente.Text);
                //Comando.Parameters.AddWithValue("@DocCor", txtCorreoDocente.Text);
                //Comando.Parameters.AddWithValue("@DocTel", txtTelefonoDocente.Text);

                //MessageBox.Show("Se agregó valor a los parametros" + "\n" + iD.ToString() + "\n" + txtNombreDocente.Text + "\n" + txtApellidoDocente.Text + "\n" + txtCorreoDocente.Text + "\n" + txtTelefonoDocente.Text, "Agregado!"); ;

                //Comando.ExecuteNonQuery();


                // Generamos una nueva instancia de la clase [dgvHorarioTableAdapter] para desplegar los docentes del usuario.
                MyScheduleDataSetTableAdapters.QueriesTableAdapter Insertar = new MyScheduleDataSetTableAdapters.QueriesTableAdapter();

                // Obtenemos los datos de la consulta.
                Insertar.InsertarDocente(iD, txtNombreDocente.Text, txtApellidoDocente.Text, txtCorreoDocente.Text, txtTelefonoDocente.Text);
            }
        }
        
        // Método para eliminar el docente seleccionado.
        internal static void EliminarDocente(int iDDocTemp, int iD)
        {
            MyScheduleDataSetTableAdapters.QueriesTableAdapter Eliminar = new MyScheduleDataSetTableAdapters.QueriesTableAdapter();

            Eliminar.EliminarDocente(iDDocTemp, iD);
        }

        // Método para desplegar las materias en el [dgvMateria].
        internal static void DesplegarMateria(DataGridView dgvMateria, int iD, int horario, int dia)
        {
            using (SqlConnection Conexión = ConexiónBD.ConectarBD())
            {
                // Generamos una nueva instancia de la clase [dgvHorarioTableAdapter] para desplegar el horario del usuario.
                MyScheduleDataSetTableAdapters.dgvMateriaTableAdapter dgvMateria1 = new MyScheduleDataSetTableAdapters.dgvMateriaTableAdapter();

                // Obtenemos los datos de la consulta.
                MyScheduleDataSet.dgvMateriaDataTable Consulta = dgvMateria1.DesplegarMateria(iD, horario, dia);

                // Desplegamos los datos en el [dgvMateria].
                dgvMateria.DataSource = Consulta;
            }
        }
    }
}
