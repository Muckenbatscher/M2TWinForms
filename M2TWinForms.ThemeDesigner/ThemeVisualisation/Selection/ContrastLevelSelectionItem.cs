using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.ThemeDesigner.ThemeVisualisation.Selection
{
    public class ContrastLevelSelectionItem : SelectionItem<ContrastLevel>
    {
        public ContrastLevelSelectionItem(string displayName, ContrastLevel contrastLevel) : 
            base(displayName, contrastLevel)
        {
        }

        public static IEnumerable<ContrastLevelSelectionItem> GetAllContrastLevelSelections()
        {
            yield return new ContrastLevelSelectionItem("Normal", ContrastLevel.Normal);
            yield return new ContrastLevelSelectionItem("Medium", ContrastLevel.Medium);
            yield return new ContrastLevelSelectionItem("High", ContrastLevel.High);
        }
    }
}
