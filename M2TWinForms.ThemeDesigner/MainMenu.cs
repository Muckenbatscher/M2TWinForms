using M2TWinForms.ThemeDesigner.HctConversionTester;
using M2TWinForms.ThemeDesigner.HctPaletteVisualisation;
using M2TWinForms.ThemeDesigner.ThemeSourcesVisualisation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.ThemeDesigner
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BT_HctConverter_Click(object sender, EventArgs e)
        {
            var hctVisualisation = new HctVisualisation();
            hctVisualisation.Show();
        }
        private void BT_PaletteGeneration_Click(object sender, EventArgs e)
        {
            var paletteGeneration = new InteractiveColorPaletteVisualisation();
            paletteGeneration.ShowDialog();
        }

        private void BT_ThemeBuilderJson_Click(object sender, EventArgs e)
        {
            var themeBuilderJsonPreview = new ThemeBuilderJsonPreview();
            themeBuilderJsonPreview.ShowDialog();
        }
        private void BT_CoreColors_Click(object sender, EventArgs e)
        {
            var coreColorsPreview = new CoreColorsPreview();
            coreColorsPreview.ShowDialog();
        }
        private void BT_SingleColor_Click(object sender, EventArgs e)
        {
            var singleColorPreview = new SingleColorPreview();
            singleColorPreview.ShowDialog();
        }

    }
}
