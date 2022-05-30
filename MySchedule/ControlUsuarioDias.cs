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
    public partial class ControlUsuarioDias : UserControl
    {
        //String connString = "server=localhost; user id=root; database=db_calendar; sslmode=none";

        // Creación de variable estatica para almacenar dia
        public static string static_dia;

        public ControlUsuarioDias()
        {
            InitializeComponent();
        }

        public void Dias(int numdias)
        {
            lblDias.Text = numdias + "";
        }

        private void ControlUsuarioDias_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            static_dia = lblDias.Text;

            // Iniciamos el contador al hacer click en un dia
            TimerRecord.Start();
            FrmRecordatorio frmRecordatorio = new FrmRecordatorio();
            frmRecordatorio.Show();

            this.Enabled = true;
        }

        // Creamos un nuevo evento que despliegue el recordatorio
        private void MostrarRecordatorio() 
        {
            //MySqlConnection conn = new MySqlConnection(connString);
            //conn.Open();
            //String sql = "SELECT * FROM tbl_calendar where date = ?";
            //MySqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = sql;
            //cmd.Parameters.AddWithValue("date", lblDias.Text + "/" + FrmCalendario.static_mes + "/" + FrmCalendario.static_año);
            //MySqlDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    lblRecordatorio.Text = reader["recordatorio"].ToString();
            //}
            //reader.Dispose();
            //cmd.Dispose();
            //conn.Close();
        }


        // Creamos un temporizador para autodesplegar el recordatorio si se añade uno nuevo

        private void TimerRecord_Tick(object sender, EventArgs e)
        {
            // Llamamos al método MostrarRecordatorio
            MostrarRecordatorio();
        }

    }
}
