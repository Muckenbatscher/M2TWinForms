using MaterialTheming.ColorDefinitions;
using MaterialTheming.Creation;
using MaterialTheming.MaterialDesign;

namespace M2TWinForms.ThemeDesigner.ThemeSourcesVisualisation
{
    public partial class CoreColorsPreview : Form
    {
        private ThemeMode SelectedThemeMode { get => SL_ThemeMode.SelectedValue; }
        private ContrastLevel SelectedContrastLevel { get => SL_ContrastLevel.SelectedValue; }
        private bool NormalizeChroma { get => CB_NormalizeChroma.Checked; }


        public CoreColorsPreview()
        {
            InitializeComponent();
            AddEventHandlers();
        }

        private void AddEventHandlers()
        {
            var buttons = new Button[] { BT_Primary, BT_Secondary, BT_Tertiary, BT_Error, BT_Neutral, BT_NeutralVariant };
            foreach (var button in buttons)
                button.Click += BT_Primary_Click;
        }

        private void BT_Primary_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender!;
            var colorPicker = new ColorDialog()
            {
                Color = button.BackColor,
                FullOpen = true,
                AnyColor = true
            };
            if (colorPicker.ShowDialog() == DialogResult.OK)
                button.BackColor = colorPicker.Color;
        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
            var theme = ThemeBuilder.Create()
                .WithPrimaryColor(c =>
                {
                    c.WithBaseColor(GetFromDrawingColor(BT_Primary.BackColor))
                     .WithFixedTargetChroma(NormalizeChroma);
                })
                .WithSecondaryColor(c =>
                {
                    c.WithBaseColor(GetFromDrawingColor(BT_Secondary.BackColor))
                     .WithFixedTargetChroma(NormalizeChroma);
                })
                .WithTertiaryolor(c =>
                {
                    c.WithBaseColor(GetFromDrawingColor(BT_Tertiary.BackColor))
                     .WithFixedTargetChroma(NormalizeChroma);
                })
                .WithErrorColor(c =>
                {
                    c.WithBaseColor(GetFromDrawingColor(BT_Error.BackColor))
                     .WithFixedTargetChroma(NormalizeChroma);
                })
                .WithNeutralColor(c =>
                {
                    c.WithBaseColor(GetFromDrawingColor(BT_Neutral.BackColor))
                     .WithFixedTargetChroma(NormalizeChroma);
                })
                .WithNeutralVariantColor(c =>
                {
                    c.WithBaseColor(GetFromDrawingColor(BT_NeutralVariant.BackColor))
                     .WithFixedTargetChroma(NormalizeChroma);
                })
                .WithMode(SelectedThemeMode)
                .WithContrastLevel(SelectedContrastLevel)
                .Build();
            CSV_Theme.LoadTheme(theme);
        }

        private RgbColor GetFromDrawingColor(Color color)
            => RgbColor.FromRgb(color.R, color.G, color.B);
    }
}
