using M2TWinForms.Themes;
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

namespace M2TWinForms.ThemeDesigner.ThemeSourcesVisualisation
{
    public partial class SingleColorPreview : Form
    {
        public int EnteredRed { get => (int)NUD_Red.Value; set => NUD_Red.Value = value; }
        public int EnteredGreen { get => (int)NUD_Green.Value; set => NUD_Green.Value = value; }
        public int EnteredBlue { get => (int)NUD_Blue.Value; set => NUD_Blue.Value = value; }

        public Color EnteredColor { get => Color.FromArgb(EnteredRed, EnteredGreen, EnteredBlue); }

        private ThemeMode SelectedThemeMode
        {
            get => SL_ThemeMode.SelectedValue;
        }
        private ContrastLevel SelectedContrastLevel
        {
            get => SL_ContrastLevel.SelectedValue;
        }


        public SingleColorPreview()
        {
            InitializeComponent();
        }

        private void TB_ColorHtml_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            var color = ColorTranslator.FromHtml(TB_ColorHtml.Text);
            EnteredRed = color.R;
            EnteredGreen = color.G;
            EnteredBlue = color.B;

            GenerateAndDisplayThemeFromSingleEnteredColor();
        }

        private void RefreshEnteredColorPreview()
            => PN_PreviewColorSelection.BackColor = EnteredColor;

        private void GenerateAndDisplayThemeFromSingleEnteredColor()
        {
            RefreshEnteredColorPreview();

            var theme = Theme.CreateFromSinglePrimaryColor(EnteredColor, SelectedThemeMode, SelectedContrastLevel);
            CSV_LoadedTheme.LoadTheme(theme);
        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
            GenerateAndDisplayThemeFromSingleEnteredColor();
        }
    }
}
