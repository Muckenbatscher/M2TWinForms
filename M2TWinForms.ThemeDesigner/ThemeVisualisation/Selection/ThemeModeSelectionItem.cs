using MaterialTheming.MaterialDesign;

namespace M2TWinForms.ThemeDesigner.ThemeVisualisation.Selection
{
    public class ThemeModeSelectionItem :
        SelectionItem<ThemeMode>
    {
        public ThemeModeSelectionItem(string displayName, ThemeMode mode) : base(displayName, mode)
        {
        }

        public static IEnumerable<ThemeModeSelectionItem> GetAllThemeModeSelections()
        {
            yield return new ThemeModeSelectionItem("Light", ThemeMode.Light);
            yield return new ThemeModeSelectionItem("Dark", ThemeMode.Dark);
        }
    }
}
