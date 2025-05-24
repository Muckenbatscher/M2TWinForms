using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Controls.Labels
{
    public class M2TLabel : Label, IThemedControl
    {
        [Obsolete("Should not be set directly. Instead use the color roles to ensure proper theming.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }
        [Obsolete("Should not be set directly. Instead use the color roles to ensure proper theming.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }


        [Description("The Material Design Color Role used for the text of the Label")]
        [Category("Material Design")]
        [DefaultValue(M2TLabelTextColorRoleSelection.OnSurface)]
        public M2TLabelTextColorRoleSelection ForeColorRole
        {
            get => _foreColorRole;
            set
            {
                _foreColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TLabelTextColorRoleSelection _foreColorRole = M2TLabelTextColorRoleSelection.OnSurface;

        [Description("The Material Design Color Role used for the background of the Label")]
        [Category("Material Design")]
        [DefaultValue(M2TLabelBackgroundColorRoleSelection.Transparent)]
        public M2TLabelBackgroundColorRoleSelection BackColorRole
        {
            get => _backColorRole;
            set
            {
                _backColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TLabelBackgroundColorRoleSelection _backColorRole = M2TLabelBackgroundColorRoleSelection.Transparent;

        public M2TLabel()
        {
            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            if (BackColorRole == M2TLabelBackgroundColorRoleSelection.Transparent)
            {
                this.BackColor = Color.Transparent;
            }
            else
            {
                var mappedBackColorRole = GetMappedBackColorRole();
                this.BackColor = CurrentLoadedThemeManager.GetColorForRole(mappedBackColorRole);
            }
            var mappedForeColorRole = GetMappedForeColorRole();
            this.ForeColor = CurrentLoadedThemeManager.GetColorForRole(mappedForeColorRole);
        }

        private ColorRoles GetMappedForeColorRole()
        {
            return ForeColorRole switch
            {
                M2TLabelTextColorRoleSelection.Primary => ColorRoles.Primary,
                M2TLabelTextColorRoleSelection.OnPrimary => ColorRoles.OnPrimary,
                M2TLabelTextColorRoleSelection.OnPrimaryContainer => ColorRoles.OnPrimaryContainer,
                M2TLabelTextColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TLabelTextColorRoleSelection.OnSecondary => ColorRoles.OnSecondary,
                M2TLabelTextColorRoleSelection.OnSecondaryContainer => ColorRoles.OnSecondaryContainer,
                M2TLabelTextColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TLabelTextColorRoleSelection.OnTertiary => ColorRoles.OnTertiary,
                M2TLabelTextColorRoleSelection.OnTertiaryContainer => ColorRoles.OnTertiaryContainer,
                M2TLabelTextColorRoleSelection.Error => ColorRoles.Error,
                M2TLabelTextColorRoleSelection.OnError => ColorRoles.OnError,
                M2TLabelTextColorRoleSelection.OnErrorContainer => ColorRoles.OnErrorContainer,
                M2TLabelTextColorRoleSelection.OnSurface => ColorRoles.OnSurface,
                M2TLabelTextColorRoleSelection.OnSurfaceVariant => ColorRoles.OnSurfaceVariant,
                _ => throw new ArgumentException($"Unknown {nameof(M2TLabelTextColorRoleSelection)} value: {ForeColorRole}"),
            };
        }

        private ColorRoles GetMappedBackColorRole()
        {
            return BackColorRole switch
            {
                M2TLabelBackgroundColorRoleSelection.Primary => ColorRoles.Primary,
                M2TLabelBackgroundColorRoleSelection.PrimaryContainer => ColorRoles.PrimaryContainer,
                M2TLabelBackgroundColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TLabelBackgroundColorRoleSelection.SecondaryContainer => ColorRoles.SecondaryContainer,
                M2TLabelBackgroundColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TLabelBackgroundColorRoleSelection.TertiaryContainer => ColorRoles.TertiaryContainer,
                M2TLabelBackgroundColorRoleSelection.Error => ColorRoles.Error,
                M2TLabelBackgroundColorRoleSelection.ErrorContainer => ColorRoles.ErrorContainer,
                M2TLabelBackgroundColorRoleSelection.Surface => ColorRoles.Surface,
                M2TLabelBackgroundColorRoleSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
                M2TLabelBackgroundColorRoleSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
                M2TLabelBackgroundColorRoleSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
                M2TLabelBackgroundColorRoleSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
                M2TLabelBackgroundColorRoleSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
                _ => throw new ArgumentException($"Unknown {nameof(M2TLabelBackgroundColorRoleSelection)} value: {BackColorRole}"),
            };
        }
    }
}