using M2TWinForms.Enumerations;
using M2TWinForms.Interfaces;
using M2TWinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.Controls.Inputs.Text
{
    public partial class M2TTextBox : TextBox, IThemedControl
    {
        [DefaultValue(ColorType.BackgroundSecondary)]
        public ColorType BackColorType
        {
            get => _backColorType;
            set
            {
                _backColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType _backColorType = ColorType.BackgroundSecondary;

        [DefaultValue(ColorType.ForegroundPrimary)]
        public ColorType ForeColorType
        {
            get => _foreColor;
            set
            {
                _foreColor = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType _foreColor = ColorType.ForegroundPrimary;

        public M2TTextBox()
        {
            InitializeComponent();
            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            this.BackColor = CurrentLoadedThemeManager.GetColorForType(BackColorType);
            this.ForeColor = CurrentLoadedThemeManager.GetColorForType(ForeColorType);
        }
    }
}
