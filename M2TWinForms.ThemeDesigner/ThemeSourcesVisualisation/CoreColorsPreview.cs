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
            var coreColors = new CoreColors()
            {
                Primary = BT_Primary.BackColor,
                Secondary = BT_Secondary.BackColor,
                Tertiary = BT_Tertiary.BackColor,
                Error = BT_Error.BackColor,
                Neutral = BT_Neutral.BackColor,
                NeutralVariant = BT_NeutralVariant.BackColor
            };
            var theme = Theme.CreateFromCoreColors(coreColors, 
                SelectedThemeMode, SelectedContrastLevel, NormalizeChroma);
            CSV_Theme.LoadTheme(theme);
        }

    }
}
