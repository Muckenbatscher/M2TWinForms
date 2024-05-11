using M2TWinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Helper
{
    internal class NestedControlThemeApplier
    {
        public static void ApplyThemeForChildControls(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is IThemedControl themedControl)
                    themedControl.ApplyCurrentLoadedTheme();

                ApplyThemeForChildControls(childControl);
            }
        }
    }
}
