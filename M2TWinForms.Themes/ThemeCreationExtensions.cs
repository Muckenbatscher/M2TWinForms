using M2TWinForms.Themes.Creation;
using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeBuilderConversion;
using M2TWinForms.Themes.ThemeBuilderConversion.SerializationModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes
{
    public partial class Theme
    {
        public static Theme CreateFromColorsProvider(IThemeColorsProvider themeColorsProvider)
        {
            var themeColors = new ThemeColors()
            {
                Primary = themeColorsProvider.Primary,
                OnPrimary = themeColorsProvider.OnPrimary,
                PrimaryContainer = themeColorsProvider.PrimaryContainer,
                OnPrimaryContainer = themeColorsProvider.OnPrimaryContainer,
                Secondary = themeColorsProvider.Secondary,
                OnSecondary = themeColorsProvider.OnSecondary,
                SecondaryContainer = themeColorsProvider.SecondaryContainer,
                OnSecondaryContainer = themeColorsProvider.OnSecondaryContainer,
                Tertiary = themeColorsProvider.Tertiary,
                OnTertiary = themeColorsProvider.OnTertiary,
                TertiaryContainer = themeColorsProvider.TertiaryContainer,
                OnTertiaryContainer = themeColorsProvider.OnTertiaryContainer,
                Error = themeColorsProvider.Error,
                OnError = themeColorsProvider.OnError,
                ErrorContainer = themeColorsProvider.ErrorContainer,
                OnErrorContainer = themeColorsProvider.OnErrorContainer,
                Surface = themeColorsProvider.Surface,
                SurfaceContainer = themeColorsProvider.SurfaceContainer,
                SurfaceContainerLowest = themeColorsProvider.SurfaceContainerLowest,
                SurfaceContainerLow = themeColorsProvider.SurfaceContainerLow,
                SurfaceContainerHigh = themeColorsProvider.SurfaceContainerHigh,
                SurfaceContainerHighest = themeColorsProvider.SurfaceContainerHighest,
                OnSurface = themeColorsProvider.OnSurface,
                OnSurfaceVariant = themeColorsProvider.OnSurfaceVariant
            };
            return new Theme() { Colors = themeColors };
        }

        public static Theme CreateFromCoreColorsProvider(ICoreColorsProvider coreColorsProvider)
        {
            throw new NotImplementedException();
        }

        public static Theme CreateFromSinglePrimaryColor(Color primaryColor)
        {
            throw new NotImplementedException();
        }

        public static Theme CreateFromMaterialDesignJson(string materialDesignJson, ThemeMode mode, ContrastLevel contrastLevel)
        {
            var deserializer = new MaterialThemeDeserializer();
            var materialTheme = deserializer.Deserialize(materialDesignJson);
            var converter = new ThemeBuilderConverter();
            Scheme selectedScheme = null;
            if (mode == ThemeMode.Light && contrastLevel == ContrastLevel.Normal)
                selectedScheme = materialTheme.Schemes.Light;
            else if (mode == ThemeMode.Light && contrastLevel == ContrastLevel.Medium)
                selectedScheme = materialTheme.Schemes.LightMediumContrast;
            else if (mode == ThemeMode.Light && contrastLevel == ContrastLevel.High)
                selectedScheme = materialTheme.Schemes.LightHighContrast;
            else if (mode == ThemeMode.Dark && contrastLevel == ContrastLevel.Normal)
                selectedScheme = materialTheme.Schemes.Dark;
            else if (mode == ThemeMode.Dark && contrastLevel == ContrastLevel.Medium)
                selectedScheme = materialTheme.Schemes.DarkMediumContrast;
            else if (mode == ThemeMode.Dark && contrastLevel == ContrastLevel.High)
                selectedScheme = materialTheme.Schemes.DarkHighContrast;
            else
                throw new ArgumentException("Invalid combination of theme mode and contrast level.");
           
            var themeColors = converter.ConvertFromThemeBuilder(selectedScheme);
            return new Theme() { Colors = themeColors };
        }

        public static Theme CreateFromMaterialDesignJson(FileInfo materialDesignJsonFile, ThemeMode mode, ContrastLevel contrastLevel)
        {
            if (!materialDesignJsonFile.Exists)
                throw new FileNotFoundException("Material Design JSON file not found.", materialDesignJsonFile.FullName);

            var materialDesignJson = File.ReadAllText(materialDesignJsonFile.FullName);
            return CreateFromMaterialDesignJson(materialDesignJson, mode, contrastLevel);
        }
    }
}
