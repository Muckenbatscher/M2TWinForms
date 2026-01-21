using MaterialTheming;
using MaterialTheming.Creation;
using MaterialTheming.MaterialDesign;
using System.ComponentModel;

namespace M2TWinForms.ThemeDesigner.ThemeSourcesVisualisation
{
    public partial class SingleColorPreview : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int EnteredRed { get => (int)NUD_Red.Value; set => NUD_Red.Value = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int EnteredGreen { get => (int)NUD_Green.Value; set => NUD_Green.Value = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
            var sourceColor = RgbColor.FromRgb(EnteredColor.R, EnteredColor.G, EnteredColor.B);
            var theme = ThemeBuilder
                .CreateFromSourceColor(sourceColor)
                .WithMode(SelectedThemeMode)
                .WithContrastLevel(SelectedContrastLevel)
                .Build();
            CSV_LoadedTheme.LoadTheme(theme);
        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
            GenerateAndDisplayThemeFromSingleEnteredColor();
        }
    }
}
