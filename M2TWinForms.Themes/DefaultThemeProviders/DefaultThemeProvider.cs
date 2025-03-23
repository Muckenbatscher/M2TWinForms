using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.DefaultThemeProviders
{
    public abstract class DefaultThemeProvider
    {
        public Theme CreateTheme()
        {
            var colors = CreateThemeColors();
            return new Theme() { Colors = colors };
        }
        protected abstract ThemeColors CreateThemeColors();
    }
}
