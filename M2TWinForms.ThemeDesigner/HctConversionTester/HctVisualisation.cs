using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.ThemeDesigner.HctConversionTester
{
    public partial class HctVisualisation : Form
    {
        public int EnteredRed { get => (int)NUD_Red.Value; set => NUD_Red.Value = value; }
        public int EnteredGreen { get => (int)NUD_Green.Value; set => NUD_Green.Value = value; }
        public int EnteredBlue { get => (int)NUD_Blue.Value; set => NUD_Blue.Value = value; }

        public int EnteredHue { get => (int)NUD_Hue.Value; set => NUD_Hue.Value = value; }
        public int EnteredChroma { get => (int)NUD_Chroma.Value; set => NUD_Chroma.Value = value; }
        public int EnteredTone { get => (int)NUD_Tone.Value; set => NUD_Tone.Value = value; }

        public HctVisualisation()
        {
            InitializeComponent();
        }

        private void BT_CalculateHct_Click(object sender, EventArgs e)
        {
            var rgbColor = Color.FromArgb(EnteredRed, EnteredGreen, EnteredBlue);
            var hctColor = new HctColor(rgbColor);
            EnteredHue = (int)hctColor.Hue;
            EnteredChroma = (int)hctColor.Chroma;
            EnteredTone = (int)hctColor.Tone;
            PN_VisualisationRgb.BackColor = rgbColor;
        }

        private void BT_CalculateRgb_Click(object sender, EventArgs e)
        {
            var hctColor = new HctColor(EnteredHue, EnteredChroma, EnteredTone);
            var rgbColor = hctColor.GetColor();
            EnteredRed = rgbColor.R;
            EnteredGreen = rgbColor.G;
            EnteredBlue = rgbColor.B;
            PN_VisualisationRgb.BackColor = rgbColor;
        }
    }
}
