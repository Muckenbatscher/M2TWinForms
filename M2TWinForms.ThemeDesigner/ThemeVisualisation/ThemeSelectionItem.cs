using M2TWinForms.Themes.Creation;
using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.ThemeDesigner.ThemeVisualisation
{
    public class ThemeSelectionItem
    {
        public string DisplayName { get; set; }
        public ThemeMode Mode { get; set; }
        public ContrastLevel ContrastLevel { get; set; }

        public ThemeSelectionItem(string displayName, ThemeMode mode, ContrastLevel contrastLevel)
        {
            DisplayName = displayName;
            Mode = mode;
            ContrastLevel = contrastLevel;
        }
    }
}
