using M2TWinForms.Themes.Creation;
using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes
{
    partial class Theme
    {
        public static Theme CreateFromCoreColors(ICoreColors coreColors, ThemeMode mode, ContrastLevel contrastLevel)
        {
            var foregroundTone = GetTone(mode, contrastLevel, false);
            var backgroundTone = GetTone(mode, contrastLevel, true);
            var containerForegroundTone = GetContainerTone(mode, contrastLevel, false);
            var containerBackgroundTone = GetContainerTone(mode, contrastLevel, true);
            var surfaceForegroundTone = GetSurfaceTone(mode, contrastLevel, false);
            var surfaceBackgroundTone = GetSurfaceTone(mode, contrastLevel, true);
            var surfaceVariantForegroundTone = GetSurfaceVariantTone(mode, contrastLevel, false);
            var surfaceVariantBackgroundTone = GetSurfaceVariantTone(mode, contrastLevel, true);
            double surfaceContainerLowestTone = mode == ThemeMode.Dark ? 0 : 100;
            double surfaceContainerLowTone = mode == ThemeMode.Dark ? 6 : 96;
            double surfaceContainerTone = mode == ThemeMode.Dark ? 9 : 94;
            double surfaceContainerHighTone = mode == ThemeMode.Dark ? 12 : 92;
            double surfaceContainerHighestTone = mode == ThemeMode.Dark ? 15 : 90;

            var primaryHct = new HctColor(coreColors.Primary);
            var primaryPalette = new HctTonalPalette(primaryHct);

            var secondaryHct = new HctColor(coreColors.Secondary);
            var secondaryPalette = new HctTonalPalette(secondaryHct);

            var tertiaryHct = new HctColor(coreColors.Tertiary);
            var tertiaryPalette = new HctTonalPalette(tertiaryHct);

            var errorHct = new HctColor(coreColors.Error);
            var errorPalette = new HctTonalPalette(errorHct);

            var neutralHct = new HctColor(coreColors.Neutral);
            var neutralPalette = new HctTonalPalette(neutralHct);

            var neutralVariantHct = new HctColor(coreColors.NeutralVariant);
            var neutralVariantPalette = new HctTonalPalette(neutralVariantHct);

            var colors = new ThemeColors()
            {
                Primary = primaryPalette.GetHctForTone(foregroundTone).GetColor(),
                OnPrimary = primaryPalette.GetHctForTone(backgroundTone).GetColor(),
                PrimaryContainer = primaryPalette.GetHctForTone(containerForegroundTone).GetColor(),
                OnPrimaryContainer = primaryPalette.GetHctForTone(containerBackgroundTone).GetColor(),
                Secondary = secondaryPalette.GetHctForTone(foregroundTone).GetColor(),
                OnSecondary = secondaryPalette.GetHctForTone(backgroundTone).GetColor(),
                SecondaryContainer = secondaryPalette.GetHctForTone(containerForegroundTone).GetColor(),
                OnSecondaryContainer = secondaryPalette.GetHctForTone(containerBackgroundTone).GetColor(),
                Tertiary = secondaryPalette.GetHctForTone(foregroundTone).GetColor(),
                OnTertiary = secondaryPalette.GetHctForTone(backgroundTone).GetColor(),
                TertiaryContainer = tertiaryPalette.GetHctForTone(containerForegroundTone).GetColor(),
                OnTertiaryContainer = tertiaryPalette.GetHctForTone(containerBackgroundTone).GetColor(),
                Error = errorPalette.GetHctForTone(foregroundTone).GetColor(),
                OnError = errorPalette.GetHctForTone(backgroundTone).GetColor(),
                ErrorContainer = errorPalette.GetHctForTone(containerForegroundTone).GetColor(),
                OnErrorContainer = errorPalette.GetHctForTone(containerBackgroundTone).GetColor(),
                Surface = neutralPalette.GetHctForTone(surfaceBackgroundTone).GetColor(),
                SurfaceContainer = neutralPalette.GetHctForTone(surfaceContainerTone).GetColor(),
                SurfaceContainerLowest = neutralPalette.GetHctForTone(surfaceContainerLowestTone).GetColor(),
                SurfaceContainerLow = neutralPalette.GetHctForTone(surfaceContainerLowTone).GetColor(),
                SurfaceContainerHigh = neutralPalette.GetHctForTone(surfaceContainerHighTone).GetColor(),
                SurfaceContainerHighest = neutralPalette.GetHctForTone(surfaceContainerHighestTone).GetColor(),
                OnSurface = neutralPalette.GetHctForTone(surfaceForegroundTone).GetColor(),
                OnSurfaceVariant = neutralVariantPalette.GetHctForTone(surfaceVariantForegroundTone).GetColor()
            };

            return new Theme() { Colors = colors };
        }

        private static double GetTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
        {
            var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 80},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 30},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 85},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 25},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 90},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 20},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 45},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 100},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 40},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 100},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 35},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 100}
            };
            return tones[Tuple.Create(mode, contrastLevel, isBackground)];
        }

        private static double GetContainerTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
        {
            var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 35},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 90},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 30},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 25},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 98},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 90},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 35},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 95},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 30},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 98},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 25}
            };

            return tones[Tuple.Create(mode, contrastLevel, isBackground)];
        }

        private static double GetSurfaceTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
        {
            var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 5},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 90},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 3},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 2},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 98},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 98},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 10},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 99},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 5},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 99},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 3}
            };

            return tones[Tuple.Create(mode, contrastLevel, isBackground)];
        }

        private static double GetSurfaceVariantTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
        {
            var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 30},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 80},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 25},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 20},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 98},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 80},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 30},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 95},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 25},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 98},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 20}
            };

            return tones[Tuple.Create(mode, contrastLevel, isBackground)];
        }

    }
}
