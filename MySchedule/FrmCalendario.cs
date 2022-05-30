using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchedule
{
    public partial class FrmCalendario : Form
    {
        int Mes, Año;

        // Se crean variables estaticas para guardar mes y año en el recordatorio
        public static int static_mes, static_año;

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            AlmacenarDias();
        }

        public FrmCalendario()
        {
            InitializeComponent();
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            // Limpiamos el contador
            ContenedorDias.Controls.Clear();

            // Decremento del mes al dar clic en anterior
            if (Mes == 1)
            {
                Mes = 13;
                Año--;
            }

            Mes--;

            String NombreMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            lblMesAño.Text = NombreMes + " " + Año;

            // Almacena mes y año del recordatorio
            static_mes = Mes;
            static_año = Año;

            // Obtenemos el calendario a partir de la fecha actual
            DateTime InicioMes = new DateTime(Año, Mes, 1);

            // Obtenemos la cantidad de dias por mes
            int Dias = DateTime.DaysInMonth(Año, Mes);

            // Convertimos InicioMes en datos de tipo Entero
            int DiasDeLaSemana = Convert.ToInt32(InicioMes.DayOfWeek.ToString("d")) + 1;

            // Creamos un control de usuario en blanco
            for (int i = 1; i <= DiasDeLaSemana; i++)
            {
                ControlUsuario ControlUsuarioBlanco = new ControlUsuario();
                ContenedorDias.Controls.Add(ControlUsuarioBlanco);
            }

            // Creamos control de usuarios para dias
            for (int i = 1; i <= Dias; i++)
            {
                ControlUsuarioDias CUDias = new ControlUsuarioDias();
                CUDias.Dias(i);
                ContenedorDias.Controls.Add(CUDias);
            }
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            // Limpiamos el contador
            ContenedorDias.Controls.Clear();

            // Incrementamos el mes al dar clic en siguiente
            if (Mes == 12)
            {
                Mes = 0;
                Año++;
            }

            Mes++;

            String NombreMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            lblMesAño.Text = NombreMes + " " + Año;

            // Almacena mes y año del recordatorio
            static_mes = Mes;
            static_año = Año;

            // Obtenemos el calendario a partir de la fecha actual
            DateTime InicioMes = new DateTime(Año, Mes, 1);

            // Obtenemos la cantidad de dias por mes
            int Dias = DateTime.DaysInMonth(Año, Mes);

            // Convertimos InicioMes en datos de tipo Entero
            int DiasDeLaSemana = Convert.ToInt32(InicioMes.DayOfWeek.ToString("d")) + 1;

            // Creamos un control de usuario en blanco
            for (int i = 1; i <= DiasDeLaSemana; i++)
            {
                ControlUsuario ControlUsuarioBlanco = new ControlUsuario();
                ContenedorDias.Controls.Add(ControlUsuarioBlanco);
            }

            // Creamos control de usuarios para dias
            for (int i = 1; i <= Dias; i++)
            {
                ControlUsuarioDias CUDias = new ControlUsuarioDias();
                CUDias.Dias(i);
                ContenedorDias.Controls.Add(CUDias);
            }
        }

        private void AlmacenarDias()
        {
            DateTime now = DateTime.Now;
            Mes = now.Month;
            Año = now.Year;

            String NombreMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            lblMesAño.Text = NombreMes + " " + Año;

            // Almacena mes y año del recordatorio
            static_mes = Mes;
            static_año = Año;

            // Obtenemos el calendario a partir de la fecha actual
            DateTime InicioMes = new DateTime(Año, Mes, 1);

            // Obtenemos la cantidad de dias por mes
            int Dias = DateTime.DaysInMonth(Año, Mes);

            // Convertimos InicioMes en datos de tipo Entero
            int DiasDeLaSemana = Convert.ToInt32(InicioMes.DayOfWeek.ToString("d")) + 1;

            // Creamos un control de usuario en blanco
            for (int i = 1; i < DiasDeLaSemana; i++)
            {
                ControlUsuario ControlUsuarioBlanco = new ControlUsuario();
                ContenedorDias.Controls.Add(ControlUsuarioBlanco);
            }

            // Creamos control de usuarios para dias
            for (int i = 1; i <= Dias; i++)
            {
                ControlUsuarioDias CUDias = new ControlUsuarioDias();
                CUDias.Dias(i);
                ContenedorDias.Controls.Add(CUDias);
            }
        }

    }
}
