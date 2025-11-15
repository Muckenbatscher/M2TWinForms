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
            var keyColor = new HctColor(EnteredHue, EnteredChroma, EnteredTone);
            var rgbColor = keyColor.GetColor();
            PN_ChosenColor.BackColor = rgbColor;

            var palette = new HctTonalPalette(keyColor);
            var colorPalette = palette.GetColorPalette();
            CPV_Palette.Visualise(colorPalette);
        }
    }
}
