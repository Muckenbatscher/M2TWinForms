using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
