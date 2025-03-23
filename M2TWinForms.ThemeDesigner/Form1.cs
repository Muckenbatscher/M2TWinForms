using M2TWinForms.ThemeDesigner.ThemeVisualisation;
using M2TWinForms.Themes;
using M2TWinForms.Themes.Creation;

namespace M2TWinForms.ThemeDesigner
{
    public partial class Form1 : Form
    {
        private MaterialDesignThemeSelection SelectedMaterialThemeSelection
        {
            get => (MaterialDesignThemeSelection)CB_SelectedTheme.SelectedValue!;
        }
        private string SelectedFilePath
        {
            get => TB_FilePath.Text;
            set => TB_FilePath.Text = value;
        }
        private string _lastOpenedDirectory = string.Empty;

        public Form1()
        {
            InitializeComponent();
            InitializeThemeSelection();
        }

        private void InitializeThemeSelection()
        {
            var selections = new List<ThemeSelectionItem>()
            {
                new ThemeSelectionItem("Light", MaterialDesignThemeSelection.Light),
                new ThemeSelectionItem("Light Medium Constrast", MaterialDesignThemeSelection.LightMediumContrast),
                new ThemeSelectionItem("Light High Constrast", MaterialDesignThemeSelection.LightHighContrast),
                new ThemeSelectionItem("Dark", MaterialDesignThemeSelection.Dark),
                new ThemeSelectionItem("Dark Medium Constrast", MaterialDesignThemeSelection.DarkMediumContrast),
                new ThemeSelectionItem("Dark High Constrast", MaterialDesignThemeSelection.DarkHighContrast)
            };
            CB_SelectedTheme.DisplayMember = nameof(ThemeSelectionItem.DisplayName);
            CB_SelectedTheme.ValueMember = nameof(ThemeSelectionItem.MaterialDesignThemeSelection);
            CB_SelectedTheme.DataSource = selections;
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
                var theme = Theme.CreateFromMaterialDesignJson(file, SelectedMaterialThemeSelection);
                CSV_LoadedTheme.LoadTheme(theme);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while loading the theme: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
