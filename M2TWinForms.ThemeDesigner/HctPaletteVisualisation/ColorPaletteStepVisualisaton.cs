using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.ThemeDesigner.HctPaletteVisualisation
{
    public partial class ColorPaletteStepVisualisaton : UserControl
    {
        public string StepName 
        { 
            get => LB_StepName.Text;
            set => LB_StepName.Text = value;
        }

        public Color StepColor 
        { 
            get => this.BackColor;
            set
            {
                this.BackColor = value;
                LB_StepColor.Text = $"#{value.R:X2}{value.G:X2}{value.B:X2}";
            }
        }

        private readonly Color _lightTextColor = Color.White;
        private readonly Color _darkTextColor = Color.Black;
        public bool LightText 
        { 
            get => LB_StepName.ForeColor == _lightTextColor;
            set
            {
                var textColor = value ? _lightTextColor : _darkTextColor;
                LB_StepName.ForeColor = textColor;
                LB_StepColor.ForeColor = textColor;
            }

        }

        public ColorPaletteStepVisualisaton()
        {
            InitializeComponent();

            StepName = "Zero";
            StepColor = Color.Black;
            LightText = true;
        }
    }
}
