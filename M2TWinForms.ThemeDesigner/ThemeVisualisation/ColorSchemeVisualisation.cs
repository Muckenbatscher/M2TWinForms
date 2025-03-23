using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M2TWinForms.Themes.ThemeLoading;
using M2TWinForms.Themes;
using M2TWinForms.Themes.MaterialDesign;

namespace M2TWinForms.ThemeDesigner.ThemeVisualisation
{
    public partial class ColorSchemeVisualisation : UserControl
    {
        private readonly LoadedThemeManager _themeManager;


        public ColorSchemeVisualisation()
        {
            InitializeComponent();
            _themeManager = new LoadedThemeManager();
        }

        public void LoadTheme(Theme theme)
        {
            _themeManager.LoadTheme(theme);
            LoadColorRoles();
        }

        private void LoadColorRoles()
        {
            var roleWithOnRoleMappings = GetRoleWithOnRoleMappings();
            foreach (var mapping in roleWithOnRoleMappings)
                SetColorWithOnColorRole(mapping);

            var roleMappings = GetRoleMappings();
            foreach (var mapping in roleMappings)
                SetColorRole(mapping);
        }


        private void SetColorWithOnColorRole(ColorRoleWithOnRoleVisualisationMapping mapping)
        {
            var color = _themeManager.GetColorForRole(mapping.Role);
            var onColor = _themeManager.GetColorForRole(mapping.OnRole);
            mapping.VisualisationControl.Color = color;
            mapping.VisualisationControl.OnColor = onColor;
        }
        private void SetColorRole(ColorRoleVisualisationMapping mapping)
        {
            var color = _themeManager.GetColorForRole(mapping.Role);
            var textColor = _themeManager.GetColorForRole(mapping.TextRole);
            mapping.VisualisationControl.Color = color;
            mapping.VisualisationControl.TextColor = textColor;
        }

        private IEnumerable<ColorRoleWithOnRoleVisualisationMapping> GetRoleWithOnRoleMappings()
        {
            return [
                new ColorRoleWithOnRoleVisualisationMapping(CRV_Primary, ColorRoles.Primary, ColorRoles.OnPrimary),
                new ColorRoleWithOnRoleVisualisationMapping(CRV_PrimaryContainer, ColorRoles.PrimaryContainer, ColorRoles.OnPrimaryContainer),
                new ColorRoleWithOnRoleVisualisationMapping(CRV_Secondary, ColorRoles.Secondary, ColorRoles.OnSecondary),
                new ColorRoleWithOnRoleVisualisationMapping(CRV_SecondaryContainer, ColorRoles.SecondaryContainer, ColorRoles.OnSecondaryContainer),
                new ColorRoleWithOnRoleVisualisationMapping(CRV_Tertiary, ColorRoles.Tertiary, ColorRoles.OnTertiary),
                new ColorRoleWithOnRoleVisualisationMapping(CRV_TertiaryContainer, ColorRoles.TertiaryContainer, ColorRoles.OnTertiaryContainer),
                new ColorRoleWithOnRoleVisualisationMapping(CRV_Error, ColorRoles.Error, ColorRoles.OnError),
                new ColorRoleWithOnRoleVisualisationMapping(CRV_ErrorContainer, ColorRoles.ErrorContainer, ColorRoles.OnErrorContainer),
            ];
        }
        private IEnumerable<ColorRoleVisualisationMapping> GetRoleMappings()
        {
            return [
                new ColorRoleVisualisationMapping(CRV_Surface, ColorRoles.Surface, ColorRoles.OnSurface),
                new ColorRoleVisualisationMapping(CRV_SurfaceContainer, ColorRoles.SurfaceContainer, ColorRoles.OnSurface),
                new ColorRoleVisualisationMapping(CRV_SurfaceContainerLowest, ColorRoles.SurfaceContainerLowest, ColorRoles.OnSurface),
                new ColorRoleVisualisationMapping(CRV_SurfaceContainerLow, ColorRoles.SurfaceContainerLow, ColorRoles.OnSurface),
                new ColorRoleVisualisationMapping(CRV_SurfaceContainerHigh, ColorRoles.SurfaceContainerHigh, ColorRoles.OnSurface),
                new ColorRoleVisualisationMapping(CRV_SurfaceContainerHighest, ColorRoles.SurfaceContainerHighest, ColorRoles.OnSurface),
                new ColorRoleVisualisationMapping(CRV_OnSurface, ColorRoles.OnSurface, ColorRoles.Surface),
                new ColorRoleVisualisationMapping(CRV_OnSurfaceVariant, ColorRoles.OnSurfaceVariant, ColorRoles.Surface),
            ];
        }
    }
}
