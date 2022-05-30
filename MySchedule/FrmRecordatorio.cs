using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace MySchedule
{
    public partial class FrmRecordatorio : Form
    {
        // Creacion de conexion
        //String connString = "server= localhost; user id=root; database=db_calendar; sslmode=none";

        // Se declara el temporizador del sistema
        System.Timers.Timer timer;

        public FrmRecordatorio()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //MySqlConecction conn = new MySqlConecction(connString);
            //conn.Open();
            //String sql = "INSERT INTO tbl_calendar(date, event) VALUES(?,?)";
            //MySqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = sql;
            //cmdCancelar.Parameters.AddWithValue("date",txtFechaInicio.Text);
            //cmdCancelar.Parameters.AddWithValue("event", txtFechaInicio.Text);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Guardado");
            //cmd.Dispose();
            //conn.Close();
        }

        private void FrmRecordatorio_Load(object sender, EventArgs e)
        {
            // Mandamos a llamar las variables estaticas creadas
            txtFechaInicio.Text = ControlUsuarioDias.static_dia + "/" + FrmCalendario.static_mes + "/" + FrmCalendario.static_año;

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Tiempo_Transcurrido;

        }

        // El delegate se usa para actualizar el label que muestra el corriendo y detenido

        //delegate void UpdateLable(Label lbl, string value);
        //void UpdateLable(Label lbl, string value) 
        //{
        //    lbl.Text = value;
        //}

        private void Tiempo_Transcurrido(object sender, System.Timers.ElapsedEventArgs e)
        {
            // El código generados es para manejar el tiempo transcurrido y procesarlo
            DateTime TiempoActual = DateTime.Now;
            DateTime TiempoUsuario = dtpAlarma.Value;
            if (TiempoActual.Hour == TiempoUsuario.Hour && TiempoActual.Minute == TiempoUsuario.Minute && TiempoActual.Second == TiempoUsuario.Second )
            {
                timer.Stop();
                try
                {
                    // Detiene la alarma

                    //UpdateLable upd = UpdateDataLable;
                    //if (lblEstado.InvokeRequired)
                    //    Invoke(upd, lblEstado, "Detener");
                    
                    SoundPlayer Sonido = new SoundPlayer();
                    Sonido.SoundLocation = "";
                    Sonido.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }

            //throw new NotImplementedException();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            dtpRecordatorio.Text = String.Empty;
            txtNombreRecordatorio.Text = String.Empty;
            txtComentario.Text = String.Empty;
            dtpAlarma.Text = String.Empty;
        }
    }
}
