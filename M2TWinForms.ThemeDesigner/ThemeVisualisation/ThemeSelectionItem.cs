using M2TWinForms.Themes.Creation;
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
        public MaterialDesignThemeSelection MaterialDesignThemeSelection { get; set; }

        public ThemeSelectionItem(string displayName, MaterialDesignThemeSelection materialDesignThemeSelection)
        {
            DisplayName = displayName;
            MaterialDesignThemeSelection = materialDesignThemeSelection;
        }
    }
}
