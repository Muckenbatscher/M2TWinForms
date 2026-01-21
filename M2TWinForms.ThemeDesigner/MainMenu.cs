using M2TWinForms.ThemeDesigner.HctConversionTester;
using M2TWinForms.ThemeDesigner.ThemeSourcesVisualisation;

namespace M2TWinForms.ThemeDesigner
{
    public partial class MainMenu : M2TForm
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

        private void BT_ThemeBuilderJson_Click(object sender, EventArgs e)
        {
            var themeBuilderJsonPreview = new ThemeBuilderJsonPreview();
            themeBuilderJsonPreview.ShowDialog();
        }
        private void BT_SingleColor_Click(object sender, EventArgs e)
        {
            var singleColorPreview = new SingleColorPreview();
            singleColorPreview.ShowDialog();
        }

    }
}
