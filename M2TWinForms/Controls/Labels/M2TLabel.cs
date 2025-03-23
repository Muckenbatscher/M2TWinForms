using M2TWinForms.Enumerations;
using M2TWinForms.Interfaces;
using M2TWinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Controls.Labels
{
    public class M2TLabel : Label, IThemedControl
    {
        [DefaultValue(ColorType.ForegroundPrimary)]
        public ColorType ForeColorType
        {
            get => _foreColorType;
            set
            {
                _foreColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType _foreColorType = ColorType.ForegroundPrimary;

        public M2TLabel()
        {
            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            this.ForeColor = CurrentLoadedThemeManager.GetColorForType(ForeColorType);
        }
    }
}
