using M2TWinForms.Enumerations;
using M2TWinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.Controls.Inputs.Buttons
{
    public partial class M2TPositiveConfirmationButton : M2TButton, IThemedControl
    {
        public M2TPositiveConfirmationButton() : base()
        {
            InitializeComponent();
            BackColorType = ColorType.PositiveConfirmationBackground;
            ForeColorType = ColorType.PositiveConfirmationForeground;
            HoverBackColorType = ColorType.PositiveConfirmationHoverBackground;
            HoverForeColorType = ColorType.PositiveConfirmationHoverForeground;
            ApplyCurrentLoadedTheme();
        }
    }
}
