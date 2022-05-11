using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MySchedule
{
    class ConexiónBD
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection(@"SERVER=LAPTOP-58M9B2VK\VENTAS;DATABASE=MySchedule_BD;Integrated security=true");

            cn.Open();

            return cn;
        }
    }
}
