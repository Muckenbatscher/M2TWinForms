using M2TWinForms.Enumerations;
using M2TWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Interfaces.DefaultTheme
{
    public interface IDefaultThemeProvider
    {
        string ThemeName { get; }
        Dictionary<ColorType, string> ColorMap { get; }
    }
}
