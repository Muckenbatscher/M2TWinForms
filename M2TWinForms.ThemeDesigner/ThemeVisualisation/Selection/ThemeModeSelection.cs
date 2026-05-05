using MaterialTheming;

namespace M2TWinForms.ThemeDesigner.ThemeVisualisation.Selection
{
    public partial class ThemeModeSelection : Selection<ThemeModeSelectionItem, ThemeMode>
    {
        public ThemeModeSelection()
        {
            InitializeComponent();

            SelectionPrompt = "Theme Mode";
            Selections = ThemeModeSelectionItem.GetAllThemeModeSelections();
        }

    }
}
