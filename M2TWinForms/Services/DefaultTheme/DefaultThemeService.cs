using M2TWinForms.Interfaces.DefaultTheme;
using M2TWinForms.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Services.DefaultTheme
{
    public class DefaultThemeService : IDefaultThemeService
    {
        private readonly IDefaultThemeProvider Provider;

        public DefaultThemeService(IDefaultThemeProvider provider)
        {
            Provider = provider;
        }

        public Theme GetTheme()
        {
            return ThemeGenerationService.GenerateTheme(Provider.ThemeName, Provider.ColorMap);
        }
    }
}
