using M2TWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Services
{
    public class ThemeFileService
    {
        public static Theme GetThemeFromFile(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            return ThemeSerializationService.Deserialize(fileContent);
        }

        public static void SaveThemeToFile(Theme theme, string filePath)
        {
            string fileContent = ThemeSerializationService.Serialize(theme);
            File.WriteAllText(filePath, fileContent);
        }
    }
}
