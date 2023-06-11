using ComponentFactory.Krypton.Toolkit;
using MySchedule.Properties;
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
    public partial class FrmEditarEliminarDocente : KryptonForm
    {
        public FrmEditarEliminarDocente()
        {
            InitializeComponent();
        }

        private void FrmEditarEliminarDocente_Load(object sender, EventArgs e)
        {
            if ((bool)Settings.Default["ModoOscuro"] == false)
                ActivarModoClaro();
            else
                ActivarModoOscuro();
        }

        private void ActivarModoOscuro()
        {
            Palette = PaletaModoOscuro;

            BackColor = Color.DimGray;

            klblPregunta.StateNormal.ShortText.Color1 = Color.White;

            kcmdEditar.Palette = PaletaModoOscuro;
            kcmdEditar.StateNormal.Back.Color1 = Color.DimGray;
            kcmdEditar.StateNormal.Back.Color2 = Color.DimGray;
            kcmdEditar.StateCommon.Content.ShortText.Color1 = Color.White;

            kcmdEliminar.Palette = PaletaModoOscuro;
            kcmdEliminar.StateNormal.Back.Color1 = Color.DimGray;
            kcmdEliminar.StateNormal.Back.Color2 = Color.DimGray;
            kcmdEliminar.StateCommon.Content.ShortText.Color1 = Color.White;

            kcmdCancelar.Palette = PaletaModoOscuro; ;
            kcmdCancelar.StateNormal.Back.Color1 = Color.DimGray;
            kcmdCancelar.StateNormal.Back.Color2 = Color.DimGray;
            kcmdCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
        }

        private void ActivarModoClaro()
        {
            Palette = PaletaModoClaro;

            BackColor = Color.FromArgb(252, 250, 250);

            klblPregunta.StateNormal.ShortText.Color1 = Color.Black;

            kcmdEditar.Palette = PaletaModoClaro;
            kcmdEditar.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdEditar.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdEditar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            kcmdEliminar.Palette = PaletaModoClaro;
            kcmdEliminar.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdEliminar.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdEliminar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);

            kcmdCancelar.Palette = PaletaModoClaro; ;
            kcmdCancelar.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kcmdCancelar.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kcmdCancelar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
        }
    }
}
