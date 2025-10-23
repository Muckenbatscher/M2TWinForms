using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms
{
    public class M2TPanel : Panel, IThemedControl
    {
        [Obsolete("Should not be set directly. Instead use the color roles to ensure proper theming.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }


        [Description("The Material Design Color Role used to determine background and text of the TextBox")]
        [Category("Material Design")]
        [DefaultValue(M2TPanelColorRoleSelection.Transparent)]
        public M2TPanelColorRoleSelection ColorRole
        {
            get => _colorRole;
            set
            {
                _colorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TPanelColorRoleSelection _colorRole = M2TPanelColorRoleSelection.Transparent;


        public void ApplyCurrentLoadedTheme()
        {
            if (ColorRole == M2TPanelColorRoleSelection.Transparent)
            {
                this.BackColor = Color.Transparent;
                return;
            }
            var backColorRole = GetMappedBackColorRole();   
            this.BackColor = CurrentLoadedThemeManager.GetColorForRole(backColorRole);

            NestedControlThemeApplier.ApplyThemeForChildControls(this);
        }

        private ColorRoles GetMappedBackColorRole()
        {
            return ColorRole switch
            {
                M2TPanelColorRoleSelection.Primary => ColorRoles.Primary,
                M2TPanelColorRoleSelection.PrimaryContainer => ColorRoles.PrimaryContainer,
                M2TPanelColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TPanelColorRoleSelection.SecondaryContainer => ColorRoles.SecondaryContainer,
                M2TPanelColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TPanelColorRoleSelection.TertiaryContainer => ColorRoles.TertiaryContainer,
                M2TPanelColorRoleSelection.Error => ColorRoles.Error,
                M2TPanelColorRoleSelection.ErrorContainer => ColorRoles.ErrorContainer,
                M2TPanelColorRoleSelection.Surface => ColorRoles.Surface,
                M2TPanelColorRoleSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
                M2TPanelColorRoleSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
                M2TPanelColorRoleSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
                M2TPanelColorRoleSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
                M2TPanelColorRoleSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
                _ => throw new ArgumentException($"Unknown {nameof(M2TPanelColorRoleSelection)} value: {ColorRole}"),
            };
        }

    }
}
