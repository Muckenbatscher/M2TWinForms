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
