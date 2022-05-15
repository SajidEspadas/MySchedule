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
        // Creamos el método [Conectar].
        public static SqlConnection ConectarBD()
        {
            // Establecemos el nombre del servidor, la base de datos a utilizar y su seguridad.
            SqlConnection cn = new SqlConnection(@"SERVER=LAPTOP-58M9B2VK\VENTAS;DATABASE=MySchedule_BD;Integrated security=true");

            // Abrimos la conexión con la base de datos.
            cn.Open();

            // Retornamos la conexión.
            return cn;
        }

        public static SqlConnection DesconectarBD()
        {
            // Establecemos el nombre del servidor, la base de datos a utilizar y su seguridad.
            SqlConnection cn = new SqlConnection(@"SERVER=LAPTOP-58M9B2VK\VENTAS;DATABASE=MySchedule_BD;Integrated security=true");

            // Cerramos la conexión con la base de datos.
            cn.Close();

            // Retornamos la conexión.
            return cn;
        }
    }
}
