using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;
using System.ComponentModel;

namespace M2TWinForms.ThemeDesigner.HctPaletteVisualisation
{
    public partial class InteractiveColorPaletteVisualisation : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int EnteredHue { get => (int)NUD_Hue.Value; set => NUD_Hue.Value = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int EnteredChroma { get => (int)NUD_Chroma.Value; set => NUD_Chroma.Value = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int EnteredTone { get => (int)NUD_Tone.Value; set => NUD_Tone.Value = value; }

        public InteractiveColorPaletteVisualisation()
        {
            InitializeComponent();
        }

        private void BT_Generate_Click(object sender, EventArgs e)
        {
            var keyColor = HctColor.From(EnteredHue, EnteredChroma, EnteredTone);
            var rgbColor = keyColor.ToRgbColor();
            PN_ChosenColor.BackColor = Color.FromArgb(rgbColor.Red, rgbColor.Green, rgbColor.Blue);

            var palette = new HctTonalPalette(keyColor);
            CPV_Palette.Visualise(palette);
        }
    }
}
