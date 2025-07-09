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
    public partial class M2TButton : Button, IThemedControl
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new FlatButtonAppearance FlatAppearance
        {
            get => base.FlatAppearance;
        }
        [DefaultValue(FlatStyle.Flat)]
        public new FlatStyle FlatStyle
        {
            get => base.FlatStyle;
            set => base.FlatStyle = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DefaultValue(false)]
        public new bool UseVisualStyleBackColor
        {
            get => base.UseVisualStyleBackColor;
            set => base.UseVisualStyleBackColor = value;
        }

        [Description("The Material Design Color Role used to determine background and text of the Button")]
        [Category("Material Design")]
        [DefaultValue(M2TButtonColorRoleSelection.Surface)]
        public M2TButtonColorRoleSelection ColorRole
        {
            get => _colorRole;
            set
            {
                _colorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TButtonColorRoleSelection _colorRole = M2TButtonColorRoleSelection.Surface;

        public M2TButton() : base()
        {
            FlatStyle = FlatStyle.Flat;
            UseVisualStyleBackColor = false;

            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            IEnumerable<M2TButtonColorRoleSelection> transparentRoles = [
                M2TButtonColorRoleSelection.PrimaryTransparent,
                M2TButtonColorRoleSelection.SecondaryTransparent,
                M2TButtonColorRoleSelection.TertiaryTransparent,
                M2TButtonColorRoleSelection.ErrorTransparent];
            bool isTransparentRole = transparentRoles.Contains(ColorRole);

            var backColorRole = GetBackgroundColorRole(ColorRole);
            var backColor = CurrentLoadedThemeManager.GetColorForRole(backColorRole);
            var foreColorRole = GetForegroundColorRole(ColorRole);
            var foreColor = CurrentLoadedThemeManager.GetColorForRole(foreColorRole);

            this.BackColor = isTransparentRole ? Color.Transparent : backColor;
            this.ForeColor = foreColor;
            this.FlatAppearance.BorderColor = foreColor;
            if (isTransparentRole)
            {
                this.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, backColor);
                this.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, backColor);
            }
            else
            {
                this.FlatAppearance.MouseOverBackColor = Color.Empty;
                this.FlatAppearance.MouseDownBackColor = Color.Empty;
            }
            var borderThickness = GetRequestedBorderThickness(ColorRole);
            this.FlatAppearance.BorderSize = borderThickness;
        }

        private static ColorRoles GetForegroundColorRole(M2TButtonColorRoleSelection colorRole)
        {
            return colorRole switch
            {
                M2TButtonColorRoleSelection.Primary => ColorRoles.OnPrimary,
                M2TButtonColorRoleSelection.PrimaryTransparent => ColorRoles.Primary,
                M2TButtonColorRoleSelection.PrimaryContainer => ColorRoles.OnPrimaryContainer,
                M2TButtonColorRoleSelection.Secondary => ColorRoles.OnSecondary,
                M2TButtonColorRoleSelection.SecondaryTransparent => ColorRoles.Secondary,
                M2TButtonColorRoleSelection.SecondaryContainer => ColorRoles.OnSecondaryContainer,
                M2TButtonColorRoleSelection.Tertiary => ColorRoles.OnTertiary,
                M2TButtonColorRoleSelection.TertiaryTransparent => ColorRoles.Tertiary,
                M2TButtonColorRoleSelection.TertiaryContainer => ColorRoles.OnTertiaryContainer,
                M2TButtonColorRoleSelection.Error => ColorRoles.OnError,
                M2TButtonColorRoleSelection.ErrorTransparent => ColorRoles.Error,
                M2TButtonColorRoleSelection.ErrorContainer => ColorRoles.OnErrorContainer,
                M2TButtonColorRoleSelection.Surface => ColorRoles.OnSurface,
                M2TButtonColorRoleSelection.SurfaceContainer => ColorRoles.OnSurface,
                M2TButtonColorRoleSelection.SurfaceContainerLowest => ColorRoles.OnSurface,
                M2TButtonColorRoleSelection.SurfaceContainerLow => ColorRoles.OnSurface,
                M2TButtonColorRoleSelection.SurfaceContainerHigh => ColorRoles.OnSurface,
                M2TButtonColorRoleSelection.SurfaceContainerHighest => ColorRoles.OnSurface,
                _ => throw new ArgumentException($"Unknown {nameof(M2TButtonColorRoleSelection)} value: {colorRole}"),
            };
        }
        private static ColorRoles GetBackgroundColorRole(M2TButtonColorRoleSelection colorRole)
        {
            return colorRole switch
            {
                M2TButtonColorRoleSelection.Primary => ColorRoles.Primary,
                M2TButtonColorRoleSelection.PrimaryTransparent => ColorRoles.Primary,
                M2TButtonColorRoleSelection.PrimaryContainer => ColorRoles.PrimaryContainer,
                M2TButtonColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TButtonColorRoleSelection.SecondaryTransparent => ColorRoles.Secondary,
                M2TButtonColorRoleSelection.SecondaryContainer => ColorRoles.SecondaryContainer,
                M2TButtonColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TButtonColorRoleSelection.TertiaryTransparent => ColorRoles.Tertiary,
                M2TButtonColorRoleSelection.TertiaryContainer => ColorRoles.TertiaryContainer,
                M2TButtonColorRoleSelection.Error => ColorRoles.Error,
                M2TButtonColorRoleSelection.ErrorTransparent => ColorRoles.Error,
                M2TButtonColorRoleSelection.ErrorContainer => ColorRoles.ErrorContainer,
                M2TButtonColorRoleSelection.Surface => ColorRoles.Surface,
                M2TButtonColorRoleSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
                M2TButtonColorRoleSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
                M2TButtonColorRoleSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
                M2TButtonColorRoleSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
                M2TButtonColorRoleSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
                _ => throw new ArgumentException($"Unknown {nameof(M2TButtonColorRoleSelection)} value: {colorRole}"),
            };
        }
        private static int GetRequestedBorderThickness(M2TButtonColorRoleSelection colorRole)
        {
            IEnumerable<M2TButtonColorRoleSelection> thicknessTwoRoles = [M2TButtonColorRoleSelection.PrimaryTransparent,
                M2TButtonColorRoleSelection.SecondaryTransparent,
                M2TButtonColorRoleSelection.TertiaryTransparent,
                M2TButtonColorRoleSelection.ErrorTransparent];

            IEnumerable<M2TButtonColorRoleSelection> thicknessZeroRoles = [M2TButtonColorRoleSelection.Primary,
                M2TButtonColorRoleSelection.Secondary,
                M2TButtonColorRoleSelection.Tertiary,
                M2TButtonColorRoleSelection.Error];

            if (thicknessTwoRoles.Contains(colorRole))
                return 2;
            else if (thicknessZeroRoles.Contains(colorRole))
                return 0;
            else
                return 1;
        }

    }
}
