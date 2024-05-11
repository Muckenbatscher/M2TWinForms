using M2TWinForms.Interfaces.DefaultTheme;
using M2TWinForms.Services.DefaultTheme.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Services.DefaultTheme
{
    public class DefaultDarkThemeService : DefaultThemeService
    {
        public DefaultDarkThemeService() : base(new DefaultDarkThemeProvider())
        {
        }
    }
}
