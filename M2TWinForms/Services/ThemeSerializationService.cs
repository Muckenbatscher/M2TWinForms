using M2TWinForms.Enumerations;
using M2TWinForms.Helper;
using M2TWinForms.Models;
using M2TWinForms.Models.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace M2TWinForms.Services
{
    public class ThemeSerializationService
    {
        public static Theme Deserialize(string serialized)
        {
            var deserialized = JsonSerializer.Deserialize<SerializedTheme>(serialized);
            return GetThemeFromSerialized(deserialized);
        } 

        public static string Serialize(Theme theme)
        {
            var serialized = GetSerializedFromTheme(theme);
            return JsonSerializer.Serialize(serialized);
        }

        private static Theme GetThemeFromSerialized(SerializedTheme theme) 
        {
            var colorUsages = new List<ColorUsage>();
            foreach (var usage in theme.Colors)
                colorUsages.Add(GetColorUsageFromSerialized(usage));

            return new Theme()
            {
                Name = theme.Name,
                Colors = colorUsages
            };

        }
        private static ColorUsage GetColorUsageFromSerialized(SerializedColorUsage usage)
        {
            var color = ColorTranslation.ColorFromHexString(usage.Color);
            var type = Enum.Parse<ColorType>(usage.ColorType);
            return new ColorUsage() { Color = color, ColorType = type };
        }

        private static SerializedTheme GetSerializedFromTheme(Theme theme)
        {
            var colorUsages = new List<SerializedColorUsage>();
            foreach (var usage in theme.Colors)
                colorUsages.Add(GetSerializedFromColorUsage(usage));

            return new SerializedTheme()
            {
                Name = theme.Name,
                Colors = colorUsages
            };

        }
        private static SerializedColorUsage GetSerializedFromColorUsage(ColorUsage usage)
        {
            var color = ColorTranslation.HexStringFromColor(usage.Color);
            var type = usage.ColorType.ToString();
            return new SerializedColorUsage() { Color = color, ColorType = type };
        }
    }
}
