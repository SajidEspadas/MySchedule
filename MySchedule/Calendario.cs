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
    public partial class Calendario : Form
    {
        // Variables que permiten el uso de las manecillas del reloj
        Graphics PictureBox;
        Pen hora, min;
        Brush Centro;

        public Calendario()
        {
            InitializeComponent();
        }

        private void btnRecordatorio_Click(object sender, EventArgs e)
        {
            //Ingresamos las características que tendra cada variable de las manecillas del reloj
            PictureBox = PicReloj.CreateGraphics(); // Define el área de dibujo
            hora = new Pen(Color.Red, 10);
            min = new Pen(Color.Red, 5);
            Centro = new SolidBrush(Color.Black);

            //Variables que son utilizadas para manipulación de las manecillas
            double xHora, yHora, xMin, yMin;
            double anguloHora, anguloMin;
            int magnitudHora = 110, magnitudMin = 165;
            int Hora, Minuto, XH, YH, XM, YM;

            // =========================Ajuste de la HORA===========================
            int.TryParse(txtHora.Text, out Hora);

            anguloHora = Hora * 30;
            anguloHora = (anguloHora - 90); // Como iniciamos la hora en 180 grados realizamos la resta
            anguloHora = (anguloHora * Math.PI) / 180; // Trabajamos el apartado de seno y coseno

            // Asiganmos los vectores con su angulo
            xHora = magnitudHora * Math.Cos(anguloHora);
            yHora = magnitudHora * Math.Sin(anguloHora);

            //Estructura para dibujar la manecilla
            XH = Convert.ToInt32(xHora);
            YH = Convert.ToInt32(yHora);

            // Coencta de manera adecuada las coordenadas de la hora
            PictureBox.DrawLine(hora, 200, 200, (XH + 200), (YH + 200));

            //==============================Ajuste de los MINUTOS================================
            int.TryParse(txtMinutos.Text, out Minuto);

            anguloMin = Minuto = 6;
            anguloMin = (anguloMin - 90);
            anguloMin = (anguloMin * Math.PI) / 180;

            xMin = magnitudMin * Math.Cos(anguloMin);
            yMin = magnitudMin * Math.Sin(anguloMin);

            XM = Convert.ToInt32(xMin);
            YM = Convert.ToInt32(yMin);

            PictureBox.DrawLine(min, 200, 200, (XM + 200), (YM + 200));

            PictureBox.FillEllipse(Centro, 185, 180, 30, 30);
        }

        private void lblMinutos_Click(object sender, EventArgs e)
        {

        }
    }
}
