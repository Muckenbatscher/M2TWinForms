using MaterialTheming;
using System.ComponentModel;

namespace M2TWinForms.ThemeDesigner.HctConversionTester
{
    public partial class HctVisualisation : Form
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int EnteredRed { get => (int)NUD_Red.Value; set => NUD_Red.Value = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int EnteredGreen { get => (int)NUD_Green.Value; set => NUD_Green.Value = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int EnteredBlue { get => (int)NUD_Blue.Value; set => NUD_Blue.Value = value; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int EnteredHue { get => (int)NUD_Hue.Value; set => NUD_Hue.Value = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int EnteredChroma { get => (int)NUD_Chroma.Value; set => NUD_Chroma.Value = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int EnteredTone { get => (int)NUD_Tone.Value; set => NUD_Tone.Value = value; }

        public HctVisualisation()
        {
            InitializeComponent();
        }

        private void BT_CalculateHct_Click(object sender, EventArgs e)
        {
            CalculateHctFromEnteredRgb();
        }

        private void CalculateHctFromEnteredRgb()
        {
            var rgbColor = RgbColor.FromRgb((byte)EnteredRed, (byte)EnteredGreen, (byte)EnteredBlue);
            var hctColor = HctColor.FromRgbColor(rgbColor);
            EnteredHue = (int)hctColor.Hue;
            EnteredChroma = (int)hctColor.Chroma;
            EnteredTone = (int)hctColor.Tone;
            PN_VisualisationRgb.BackColor = Color.FromArgb(rgbColor.Red, rgbColor.Green, rgbColor.Blue);
        }

        private void BT_CalculateRgb_Click(object sender, EventArgs e)
        {
            CalculateRgbFromEnteredHct();
        }

        private void CalculateRgbFromEnteredHct()
        {
            var hctColor = HctColor.From(EnteredHue, EnteredChroma, EnteredTone);
            var rgbColor = hctColor.ToRgbColor();
            EnteredRed = rgbColor.Red;
            EnteredGreen = rgbColor.Green;
            EnteredBlue = rgbColor.Blue;
            PN_VisualisationRgb.BackColor = Color.FromArgb(rgbColor.Red, rgbColor.Green, rgbColor.Blue);
        }

        private void TB_RgbColorHtml_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            var color = ColorTranslator.FromHtml(TB_RgbColorHtml.Text);
            EnteredRed = color.R;
            EnteredGreen = color.G;
            EnteredBlue = color.B;
            CalculateHctFromEnteredRgb();
        }
    }
}
