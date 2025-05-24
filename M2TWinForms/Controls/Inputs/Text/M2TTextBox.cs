using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms
{
    public partial class M2TTextBox : TextBox, IThemedControl
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

        [DefaultValue(BorderStyle.FixedSingle)]
        public new BorderStyle BorderStyle
        {
            get => base.BorderStyle;
            set => base.BorderStyle = value;
        }


        [Description("The Material Design Color Role used to determine background and text of the TextBox")]
        [Category("Material Design")]
        [DefaultValue(M2TTextBoxColorRoleSelection.Surface)]
        public M2TTextBoxColorRoleSelection ColorRole
        {
            get => _colorRole;
            set
            {
                _colorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TTextBoxColorRoleSelection _colorRole = M2TTextBoxColorRoleSelection.Surface;

        public M2TTextBox() : base()
        {
            BorderStyle = BorderStyle.FixedSingle;
            ColorRole = M2TTextBoxColorRoleSelection.Surface;
            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            this.BackColor = CurrentLoadedThemeManager.GetColorForRole(GetBackgroundRole());
            this.ForeColor = CurrentLoadedThemeManager.GetColorForRole(GetForegroundRole());
        }

        private ColorRoles GetForegroundRole()
        {
            return ColorRole switch
            {
                M2TTextBoxColorRoleSelection.Primary => ColorRoles.OnPrimary,
                M2TTextBoxColorRoleSelection.PrimaryContainer => ColorRoles.OnPrimaryContainer,
                M2TTextBoxColorRoleSelection.Secondary => ColorRoles.OnSecondary,
                M2TTextBoxColorRoleSelection.SecondaryContainer => ColorRoles.OnSecondaryContainer,
                M2TTextBoxColorRoleSelection.Tertiary => ColorRoles.OnTertiary,
                M2TTextBoxColorRoleSelection.TertiaryContainer => ColorRoles.OnTertiaryContainer,
                M2TTextBoxColorRoleSelection.Error => ColorRoles.OnError,
                M2TTextBoxColorRoleSelection.ErrorContainer => ColorRoles.OnErrorContainer,
                M2TTextBoxColorRoleSelection.Surface => ColorRoles.OnSurface,
                M2TTextBoxColorRoleSelection.SurfaceContainer => ColorRoles.OnSurface,
                M2TTextBoxColorRoleSelection.SurfaceContainerLowest => ColorRoles.OnSurface,
                M2TTextBoxColorRoleSelection.SurfaceContainerLow => ColorRoles.OnSurface,
                M2TTextBoxColorRoleSelection.SurfaceContainerHigh => ColorRoles.OnSurface,
                M2TTextBoxColorRoleSelection.SurfaceContainerHighest => ColorRoles.OnSurface,
                M2TTextBoxColorRoleSelection.SurfaceVariant => ColorRoles.OnSurfaceVariant,
                M2TTextBoxColorRoleSelection.SurfaceContainerVariant => ColorRoles.OnSurfaceVariant,
                M2TTextBoxColorRoleSelection.SurfaceContainerLowestVariant => ColorRoles.OnSurfaceVariant,
                M2TTextBoxColorRoleSelection.SurfaceContainerLowVariant => ColorRoles.OnSurfaceVariant,
                M2TTextBoxColorRoleSelection.SurfaceContainerHighVariant => ColorRoles.OnSurfaceVariant,
                M2TTextBoxColorRoleSelection.SurfaceContainerHighestVariant => ColorRoles.OnSurfaceVariant,
                _ => throw new ArgumentException($"Unknown {nameof(M2TTextBoxColorRoleSelection)} value: {ColorRole}")
            };
        }
        private ColorRoles GetBackgroundRole()
        {
            return ColorRole switch
            {
                M2TTextBoxColorRoleSelection.Primary => ColorRoles.Primary,
                M2TTextBoxColorRoleSelection.PrimaryContainer => ColorRoles.PrimaryContainer,
                M2TTextBoxColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TTextBoxColorRoleSelection.SecondaryContainer => ColorRoles.SecondaryContainer,
                M2TTextBoxColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TTextBoxColorRoleSelection.TertiaryContainer => ColorRoles.TertiaryContainer,
                M2TTextBoxColorRoleSelection.Error => ColorRoles.Error,
                M2TTextBoxColorRoleSelection.ErrorContainer => ColorRoles.ErrorContainer,
                M2TTextBoxColorRoleSelection.Surface => ColorRoles.Surface,
                M2TTextBoxColorRoleSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
                M2TTextBoxColorRoleSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
                M2TTextBoxColorRoleSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
                M2TTextBoxColorRoleSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
                M2TTextBoxColorRoleSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
                M2TTextBoxColorRoleSelection.SurfaceVariant => ColorRoles.Surface,
                M2TTextBoxColorRoleSelection.SurfaceContainerVariant => ColorRoles.SurfaceContainer,
                M2TTextBoxColorRoleSelection.SurfaceContainerLowestVariant => ColorRoles.SurfaceContainerLowest,
                M2TTextBoxColorRoleSelection.SurfaceContainerLowVariant => ColorRoles.SurfaceContainerLow,
                M2TTextBoxColorRoleSelection.SurfaceContainerHighVariant => ColorRoles.SurfaceContainerHigh,
                M2TTextBoxColorRoleSelection.SurfaceContainerHighestVariant => ColorRoles.SurfaceContainerHighest,
                _ => throw new ArgumentException($"Unknown {nameof(M2TTextBoxColorRoleSelection)} value: {ColorRole}")
            };
        }
    }
}
