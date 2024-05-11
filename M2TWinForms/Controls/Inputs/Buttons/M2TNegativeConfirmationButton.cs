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
    public partial class M2TNegativeConfirmationButton : M2TButton, IThemedControl
    {
        public M2TNegativeConfirmationButton()
        {
            InitializeComponent();
            BackColorType = ColorType.NegativeConfirmationBackground;
            ForeColorType = ColorType.NegativeConfirmationForeground;
            HoverBackColorType = ColorType.NegativeConfirmationHoverBackground;
            HoverForeColorType = ColorType.NegativeConfirmationHoverForeground;
            ApplyCurrentLoadedTheme();
        }
    }
}
