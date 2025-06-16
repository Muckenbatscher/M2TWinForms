using M2TWinForms.ThemeDesigner.HctConversionTester;
using M2TWinForms.Themes;
using M2TWinForms.Themes.MaterialDesign;

namespace M2TWinForms.ThemeDesigner
{
    public partial class ThemeBuilderJsonPreview : Form
    {
        private ThemeMode SelectedThemeMode
        {
            get => SL_ThemeMode.SelectedValue;
        }
        private ContrastLevel SelectedContrastLevel
        {
            get => SL_ContrastLevel.SelectedValue;
        }
        private string SelectedFilePath
        {
            get => TB_FilePath.Text;
            set => TB_FilePath.Text = value;
        }
        private string _lastOpenedDirectory = string.Empty;

        public ThemeBuilderJsonPreview()
        {
            InitializeComponent();
        }

        private void BT_Browse_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (!string.IsNullOrEmpty(_lastOpenedDirectory))
                dialog.InitialDirectory = _lastOpenedDirectory;
            else
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "JSON files (*.json)|*.json";
            dialog.Title = "Select a theme file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedFilePath = dialog.FileName;
                _lastOpenedDirectory = Path.GetDirectoryName(dialog.FileName) ?? string.Empty;
            }
        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                var file = new FileInfo(SelectedFilePath);
                var theme = Theme.CreateFromMaterialDesignJson(file, SelectedThemeMode, SelectedContrastLevel);
                CSV_LoadedTheme.LoadTheme(theme);
            }
            catch (Exception ex)
            {
                M2TMessageBoxDialog.Show($"An error occured while loading the theme: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
