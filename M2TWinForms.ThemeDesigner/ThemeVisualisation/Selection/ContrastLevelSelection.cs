using MaterialTheming.MaterialDesign;

namespace M2TWinForms.ThemeDesigner.ThemeVisualisation.Selection
{
    public partial class ContrastLevelSelection : Selection<ContrastLevelSelectionItem, ContrastLevel>
    {
        public ContrastLevelSelection()
        {
            InitializeComponent();

            SelectionPrompt = "Contrast Level";
            Selections = ContrastLevelSelectionItem.GetAllContrastLevelSelections();
        }
    }
}
